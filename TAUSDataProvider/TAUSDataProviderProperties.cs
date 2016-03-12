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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Microsoft.Sample.Multilingual.Provider
{
    /// <summary>
    /// Metadata support by the TAUS DATA APIs
    /// </summary>
    public class TAUSDataProviderProperties
    {
        [Category("Metadata")]
        [LocalizedDisplayNameAttribute("PropertyProductDisplayName")]
        [LocalizedDescriptionAttribute("PropertyProductDescription")]
        public String Product { get; set; }

        [Category("Metadata")]
        [LocalizedDisplayNameAttribute("PropertyProviderDisplayName")]
        [LocalizedDescriptionAttribute("PropertyProviderDescription")]
        public String Provider { get; set; }

        [Category("Metadata")]
        [LocalizedDisplayNameAttribute("PropertyContentTypeDisplayName")]
        [LocalizedDescriptionAttribute("PropertyContentTypeDescription")]
        public String ContentType { get; set; }

        [Category("Metadata")]
        [LocalizedDisplayNameAttribute("PropertyIndustryDisplayName")]
        [LocalizedDescriptionAttribute("PropertyIndustryDescription")]
        public String Industry { get; set; }

        [Category("Metadata")]
        [LocalizedDisplayNameAttribute("PropertyOwnerDisplayName")]
        [LocalizedDescriptionAttribute("PropertyOwnerDescription")]
        public String Owner { get; set; }
    }

    /// <summary>
    /// Provides the Localized metadata's display name
    /// </summary>
    /// <remarks>
    /// See: http://msdn.microsoft.com/en-us/library/vstudio/System.ComponentModel.DisplayNameAttribute(v=vs.100).aspx
    /// </remarks>
    sealed public class LocalizedDisplayNameAttribute : DisplayNameAttribute
    {
        private readonly string resourceName;
        public LocalizedDisplayNameAttribute(string resourceName)
            : base()
        {
            this.resourceName = resourceName;
        }

        public override string DisplayName
        {
            get
            {
                return Resources.TAUSResources.ResourceManager.GetString(this.resourceName);
            }
        }
    }

    /// <summary>
    /// Provides the Localized metadata's description.
    /// </summary>
    /// <remarks>
    /// See: http://msdn.microsoft.com/en-us/library/vstudio/system.componentmodel.descriptionattribute(v=vs.100).aspx
    /// </remarks>
    sealed public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        private readonly string resourceName;
        public LocalizedDescriptionAttribute(string resourceName)
            : base()
        {
            this.resourceName = resourceName;
        }

        public override string Description
        {
            get
            {
                return Resources.TAUSResources.ResourceManager.GetString(this.resourceName);
            }
        }
    }
}
