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
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Xml.Linq;
using Localizable = Microsoft.Sample.Multilingual.Provider.Resources.TAUSResources;

namespace Microsoft.Sample.Multilingual.Provider
{
    /// <summary>
    /// Using the TAUS terminology server as a translation provider
    /// </summary>
    /// <remarks>
    /// Since TAUS DATA is a designed as a terminology lookup service, the results will include any word that matches.
    /// </remarks>
    internal class TAUSDataAccess
    {
        /// <summary>
        /// Store the retrieve credentials for this session
        /// </summary>
        static CredentialCache CredCache = new CredentialCache();

        /// <summary>
        /// Get the list of support languages
        /// </summary>
        /// <param name="credCache"></param>
        /// <returns>List of support languages</returns>
        /// <remarks>
        /// The TAUS DATA API supports multi-directional lookups across all 
        /// languages so no special language pair matching required.
        /// </remarks>
        static internal List<CultureInfo> GetLanguages(CredentialCache credCache)
        {
            //CredCache = credCache;

            //HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://www.tausdata.org/api/lang.xml");
            //httpRequest.Credentials = CredCache;

            List<CultureInfo> languages = new List<CultureInfo>();

            //  Read the contents of the response and load in the XDocument
            //XDocument docResponse = GetXmlFormatResponse(httpRequest);
            //if (docResponse != null)
            //{
                //foreach (XElement langID in docResponse.Descendants("id"))
                foreach (ResxTranslator.Language langID in ResxTranslator.Language.TranslatableCollection)
                {
                    try
                    {
                        languages.Add(new CultureInfo(langID.Value));
                    }
                    catch (CultureNotFoundException) { }  //  Ignore unknown cultures
                }
            //}
            languages.Add(new CultureInfo("en-US"));
            return languages;
        }

        /// <summary>
        /// Queries the provider for matching translation 
        /// </summary>
        /// <param name="srcCulture">Culture of the requested string</param>
        /// <param name="trgCulture">Culture of the resulting strings</param>
        /// <param name="srcString">String to translate</param>
        /// <returns>TranslationRequest</returns>
        /// <remarks>
        /// Multiple results are returned, so this filters it down to a single result, or none if match is found.
        /// </remarks>
        static internal TranslationResult GetSegmentTranslation(CultureInfo srcCulture, CultureInfo trgCulture, string srcString)
        {
            //String encodedSource = srcString.Replace(' ', '+');
            //String urlString = String.Format("https://www.tausdata.org/api/segment.xml?source_lang={0}&target_lang={1}&q={2}&fuzzy=false", srcCulture.Name, trgCulture.Name, encodedSource);

            //HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(urlString);
            //httpRequest.Credentials = CredCache;

            //  Set default
            TranslationResult transResult = new TranslationResult()
            {
                //RequestId = request.RequestId,
                TranslationState = new TranslationState() { State = TransState.NoMatch, SubState = "no match found" },
                Confidence = 0
            };

            ////  Read the contents of the response and load it into an XDocument
            //XDocument docResponse = GetXmlFormatResponse(httpRequest);
            //if (docResponse != null)
            //{
            //    foreach (XElement trans in docResponse.Descendants("segment"))
            //    {
            //        String source = trans.Element("source").Value;
            String source = srcString;

            //  Select the best translation that mets the minimum confidence requirement.
            //double confidence = CalculateConfidence(srcString, source);
            double confidence = 75;
                    if (confidence > transResult.Confidence)
                    {
                        transResult.ProviderName = Localizable.ProviderDisplayName;
                        transResult.Source = source;
                        transResult.Target = ResxTranslator.Translator.TranslateText(srcString, srcCulture.TwoLetterISOLanguageName + "|" + trgCulture.TwoLetterISOLanguageName); //trans.Element("target").Value;
                        transResult.TranslationState = new TranslationState() { State = TransState.NeedsReview };
                        transResult.TranslationType = new TranslationType() { Type = TransType.TranslationMemory };
                        transResult.Properties = new TAUSDataProviderProperties() { Provider = "Google Translate", Product = "Google Translate", Owner = "Google", Industry = "Translation", ContentType = "Text" }; // GetMetadata(trans);
                        transResult.Confidence = confidence;
                    }

                    //  If we have 100% confidence, stop looking for a better translation.
                    if (transResult.Confidence == 100)
                    {
                        //  Mark as translated instead of needs review
                        transResult.TranslationState.State = TransState.Translated;
                        //break;
                    }
            //    }
            //}

            return transResult;
        }
        
        /// <summary>
        /// Queries the provider for matching translation suggestions
        /// </summary>
        /// <param name="srcCulture">Culture of the requested string</param>
        /// <param name="trgCulture">Culture of the resulting strings</param>
        /// <param name="srcString">String to translate</param>
        /// <param name="maxResults">Maximum allowed results</param>
        /// <returns>Zero to maxResult of SuggestionResult[]</returns>
        /// <remarks>
        /// Multiple results are returned, so this filters it down to the maximum allows results.
        /// </remarks>
        static internal SuggestionResult[] GetSegmentSuggestions(CultureInfo srcCulture, CultureInfo trgCulture, string srcString, int maxResults)
        {
            //String encodedSource = srcString.Replace(' ', '+');
            //String urlString = String.Format("https://www.tausdata.org/api/segment.xml?source_lang={0}&target_lang={1}&q={2}&fuzzy=false", srcCulture.Name, trgCulture.Name, encodedSource);

            //HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(urlString);
            //httpRequest.Credentials = CredCache;

            //  Set default result
            List<SuggestionResult> suggestResults = new List<SuggestionResult>();

            //  Read the contents of the response and load it into an XDocument
            //XDocument docResponse = GetXmlFormatResponse(httpRequest);
            //if (docResponse != null)
            //{
            //    foreach (XElement trans in docResponse.Descendants("segment"))
            //    {
            //        String source = trans.Element("source").Value;
            //        String target = trans.Element("target").Value;
            String source = srcString;
            String target = ResxTranslator.Translator.TranslateText(srcString, srcCulture.TwoLetterISOLanguageName + "|" + trgCulture.TwoLetterISOLanguageName);
            SuggestionResult suggestResult = new SuggestionResult()
                    {
                        Source = source,
                        Target = target,
                        ProviderName = Localizable.ProviderDisplayName,
                        TranslationState = new TranslationState() { State = TransState.NeedsReview },
                        TranslationType = new TranslationType() { Type = TransType.TranslationMemory }
                    };

                    suggestResult.Confidence = 50;//CalculateConfidence(srcString, suggestResult.Source);
                    suggestResult.Properties = new TAUSDataProviderProperties() { Provider = "Google Translate", Product = "Google Translate", Owner = "Google", Industry = "Translation", ContentType = "Text" };// GetMetadata(trans);
                    suggestResults.Add(suggestResult);
                    if (suggestResults.Count >= maxResults)
                    {
                        //break;
                    }
            //    }
            //}

            // The code assumes the result are in best to worst matching order.
            SuggestionResult[] sortedResults = suggestResults.ToArray();
            Array.Sort(sortedResults, new SuggestionConfidenceComparer());
            return sortedResults;
        }

        /// <summary>
        /// Calculates the Confidence Level from the original and referenced source values
        /// </summary>
        /// <param name="originalSource"></param>
        /// <param name="referenceSource"></param>
        /// <returns>Confidence level</returns>
        /// <remarks>
        /// This ad-hoc confidence level calculation is needed since the TAUS service 
        /// is designed as a word level match for terminology lookup as compared to a 
        /// translation service.  If this were to be used in production, using an 
        /// industry standard confidence level should be used.
        /// </remarks>
        static private double CalculateConfidence(string originalSource, string referenceSource)
        {
            //  If the source strings match exactly, assume 100 confidence level
            if (originalSource.Equals(referenceSource, StringComparison.InvariantCulture) == true)
                return 100;

            //  If the source strings match exactly - except for case, assume 95 confidence level
            if (originalSource.Equals(referenceSource, StringComparison.InvariantCultureIgnoreCase) == true)
                return 95;

            //  Since the min default confidence level is 75 for Translate and 50 for suggest, 
            //  Using a default of 50 returns all responses for suggest API, but filters for translate APIs
            return 50;  
        }

        /// <summary>
        /// Retrieve the metadata from the response
        /// </summary>
        /// <param name="transResponse">Translation response node</param>
        /// <returns>TAUSDataProviderProperties as an object</returns>
        static private object GetMetadata(XElement transResponse)
        {
            TAUSDataProviderProperties properties = new TAUSDataProviderProperties();
            properties.Provider = GetMetadatItem(transResponse, "provider");
            properties.Owner = GetMetadatItem(transResponse, "owner");
            properties.Industry = GetMetadatItem(transResponse, "industry");
            properties.ContentType = GetMetadatItem(transResponse, "content_type");
            properties.Product = GetMetadatItem(transResponse, "product");
            return properties;
        }

        /// <summary>
        /// Get the related metadata name and value
        /// </summary>
        /// <param name="transResponse"></param>
        /// <param name="elementName"></param>
        /// <returns>Return the metadata value, or null if not found</returns>
        static private string GetMetadatItem(XElement transResponse, String elementName)
        {
            if (transResponse.Element(elementName) != null && transResponse.Element(elementName).Element("name") != null)
                return transResponse.Element(elementName).Element("name").Value;

            return null;
        }

        /// <summary>
        /// Get the XML based response
        /// </summary>
        /// <param name="HttpWReq"></param>
        /// <returns>XDocument</returns>
        static private XDocument GetXmlFormatResponse(HttpWebRequest HttpWReq)
        {
            XDocument docResponse = null;

            HttpWebResponse httpResponse = (HttpWebResponse)HttpWReq.GetResponse();

            //  Read the contents of the response and load it in the XDocument
            using (Stream responseData = httpResponse.GetResponseStream())
            {
                docResponse = XDocument.Load(responseData);
            }

            httpResponse.Close();

            return docResponse;
        }
    }
}
