//===========================================================================
//  Microsoft Public License (MS-PL) 
//  http://opensource.org/licenses/ms-pl.html
//
//  This license governs use of the accompanying software. If you use the 
//  software, you accept this license. If you do not accept the license, do 
//  not use the software.
//
//  See the Readme.txt file for build and deployment instructions.
//
//  Version   Date        History
//  1.0.0.0   2014-02-24  Creation of the TAUS based sample provider
//===========================================================================

using Microsoft.Multilingual.Translation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security;
using System.Xml.Linq;
using Localizable = Microsoft.Sample.Multilingual.Provider.Resources.TAUSResources;

namespace Microsoft.Sample.Multilingual.Provider
{
    public class TAUSDataProvider : ITranslationProvider
    {
        private CredentialCache CredCache = new CredentialCache();
        private List<CultureInfo> supportedLanguages;
        private CultureInfo SourceCulture { get; set; }
        private CultureInfo TargetCulture { get; set; }

        Stream logoTranslateStandard = null;
        Stream logoSuggestStandard = null;

        public TAUSDataProvider(String configFile)
        {
            //  Load the providers images
            Assembly providerAssembly = Assembly.GetExecutingAssembly();
            logoTranslateStandard = providerAssembly.GetManifestResourceStream("Microsoft.Sample.Multilingual.Provider.Images.TAUSTranslateLogo.png");
            logoSuggestStandard = providerAssembly.GetManifestResourceStream("Microsoft.Sample.Multilingual.Provider.Images.TAUSSuggestLogo.png");

            //  Load the configuration that contains the Credential Manager entry to use for the TAUS DATA APIs.
            //XDocument doc = XDocument.Load(configFile);
            //XElement userElement = doc.Element("Account").Element("User");
            //String url = userElement.Attribute("Url").Value;
            //String type = userElement.Attribute("Type").Value;

            ////  Read the User name and password from the Windows Credential Manager
            //String user = null;
            //SecureString pass = null;
            //Boolean result = CredentialManagerHelper.ReadCredentials(url, CRED_TYPE.GENERIC, 0, out user, out pass);
            //if (result == false)
            //    throw new InvalidProviderConfigurationException(Localizable.ProviderCredentialError);

            //NetworkCredential tausCreds = new NetworkCredential(user, pass);
            //CredCache.Add(new Uri(url), type, tausCreds);

            ////  Get the supported Languages List - Consider caching the previous list for better performance
            supportedLanguages = TAUSDataAccess.GetLanguages(CredCache);
        }

        #region public methods
        /// <summary>
        /// Initializes the provider for a set language pair
        /// </summary>
        /// <param name="source">CultureInfo for source language</param>
        /// <param name="target">CultureInfo for target language</param>
        /// <param name="initializationData">Class containing the project's Name and Version</param>
        public void Initialize(CultureInfo source, CultureInfo target, ProjectInfo initializationData)
        {
            //  validate parameters
            if (source == null)
                throw new ArgumentNullException("source");
            if (target == null)
                throw new ArgumentNullException("target");

            SourceCulture = source;
            TargetCulture = target;
        }

        /// <summary>
        /// Get all Supported Language pairs from the service
        /// </summary>
        /// <returns>list of supported CultureInfo</returns>
        public CultureInfo[] GetTargets(CultureInfo source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            //  Is the source in the language list
            if (supportedLanguages.Find(p => p.Equals(source)) == null)
            {
                return new CultureInfo[0]; //  Culture is not supported, so return an empty array
            }
            else
            {
                return supportedLanguages.ToArray();
            }
        }

        /// <summary>
        /// Checks provider supported language pairs.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool IsSupported(CultureInfo source, CultureInfo target)
        {
            //  Validate parameters
            if (source == null)
                throw new ArgumentNullException("source");
            if (target == null)
                throw new ArgumentNullException("target");

            if (supportedLanguages.Find(p => p.Equals(source)) == null)
                return false;

            if (supportedLanguages.Find(p => p.Equals(target)) == null)
                return false;

            return true;
        }

        /// <summary>
        /// Attempts to translates a resource
        /// </summary>
        /// <param name="translationUnit">TranslationUnit instance</param>        
        /// <returns>True if the resource is translated, otherwise returns false </returns>
        public TranslationResult Translate(TranslationRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");
            if (String.IsNullOrWhiteSpace(request.Source) == true)
                throw new ArgumentException("TranslationRequest.Source");
            if (SourceCulture == null)
                throw new InvalidProviderConfigurationException("SourceCulture");
            if (TargetCulture == null)
                throw new InvalidProviderConfigurationException("TargetCulture");
            if (supportedLanguages == null)
                throw new InvalidProviderConfigurationException("supported languages has not been initialized");

            //  Set default
            TranslationResult result = TAUSDataAccess.GetSegmentTranslation(SourceCulture, TargetCulture, request.Source);
            result.RequestId = request.RequestId;
            return result;
        }

        /// <summary>
        /// Attempts to find translation suggestions based the specified options in SuggestionRequest object.
        /// </summary>
        /// <param name="request">Suggestion Parameters</param>
        /// <returns>A list of suggestion result</returns>
        public SuggestionResult[] Suggest(SuggestionRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");
            if (String.IsNullOrWhiteSpace(request.Source) == true)
                throw new ArgumentException("SuggestionRequest.Source");
            if (SourceCulture == null)
                throw new InvalidProviderConfigurationException("SourceCulture");
            if (TargetCulture == null)
                throw new InvalidProviderConfigurationException("TargetCulture");
            if (supportedLanguages == null)
                throw new InvalidProviderConfigurationException("support languages has not been initialized");

            return TAUSDataAccess.GetSegmentSuggestions(SourceCulture, TargetCulture, request.Source, request.ProviderMaxResults);
        }

        /// <summary>
        /// Get provider logo from provider.
        /// </summary>
        /// <returns>Image in Bitmap format</returns>
        public Stream GetProviderLogo(ProviderLogoStyle style)
        {
            switch (style)
            {
                case ProviderLogoStyle.SuggestStandard:
                    return logoSuggestStandard;

                case ProviderLogoStyle.TranslateStandard:
                    return logoTranslateStandard;

                default:
                    throw new NotSupportedException(style.ToString());
            }
        }

        /// <summary>
        /// Provider cleanup, as needed
        /// </summary>
        public void Dispose()
        {
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Localized Display Name
        /// </summary>
        public String DisplayName
        {
            get { return Localizable.ProviderDisplayName; }
        }

        /// <summary>
        /// Localized Description
        /// </summary>
        public String Description
        {
            get { return Localizable.ProviderDescription; }
        }
        #endregion
    }
}
