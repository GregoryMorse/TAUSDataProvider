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
using System.Linq;
using System.Text;

namespace Microsoft.Sample.Multilingual.Provider
{
    /// <summary>
    /// Suggestion Confidence level comparer
    /// </summary>
    internal class SuggestionConfidenceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            SuggestionResult xResult = x as SuggestionResult;
            SuggestionResult yResult = y as SuggestionResult;

            //  Get the nulls out of the way.
            if (xResult == null && yResult == null)
                return 0;

            if (xResult == null)
                return 1;

            if (yResult == null)
                return -1;

            if (xResult.Confidence < yResult.Confidence)
                return 1;

            if (xResult.Confidence > yResult.Confidence)
                return -1;

            return 0;
        }
    }
}
