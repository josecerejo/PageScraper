using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Net;
using System.IO;

namespace ForeclosureDataRetriever
{
    public class TaxScraper
    {
        #region private strings
        public string RootURL { get; private set; }
        public string ActualURL { get; private set; }
        private string SID { get; set; }
        private string URLData;
        #endregion

        public TaxScraper()
        {
            RootURL = "http://fl-duval-taxcollector.governmax.com";
        }

        public virtual void ScrapePage()
        {
        }

        public string FindSID(string source)
        {
            SID = Regex.Match(source, @"sid=.{32}").Value;
            return Regex.Match(SID, @"[^sid=]").Value;
        }
    }
}
