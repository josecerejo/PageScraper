using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Web;
using System.Net;
using System.IO;

namespace ForeclosureDataRetriever
{
    public class COJScraper : Scraper
    {
        #region private strings
        public string Bedrooms { get; private set; }
        public string Bathrooms { get; private set; }
        public string SqFt { get; private set; }
        public string YrBuilt { get; private set; }
        #endregion
        
        public COJScraper(string url)
        {
            base.URL = url;
            ScrapePage();
        }

        public override void ScrapePage()
        {
            base.ScrapePage();
            SetStringProperties();
            ParseStrings();
        }

        public override void SetStringProperties()
        {
            Bedrooms = Regex.Match(base.URLData, @"Bedrooms\D+\d+\.\d+").Value;
            Bathrooms = Regex.Match(base.URLData, @"Baths\D+\d+\.\d+").Value;
            SqFt = Regex.Match(base.URLData, @"Total\D{9}\d+\D+\d+").Value;
            YrBuilt = Regex.Match(base.URLData, @"YearBuilt\D+\d{4}").Value;
        }

        public override void ParseStrings()
        {
            Bedrooms = Regex.Match(Bedrooms, @"\d+\.\d+$").Value;
            Bathrooms = Regex.Match(Bathrooms, @"\d+\.\d+$").Value;
            SqFt = Regex.Match(SqFt, @"\d+$").Value;
            YrBuilt = Regex.Match(YrBuilt, @"\d+").Value;
        }
    }
}
