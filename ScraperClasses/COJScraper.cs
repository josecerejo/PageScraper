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
        private string Bedrooms;
        private string Bathrooms;
        private string SqFt;
        private string YrBuilt;
        #endregion

        #region public integers
        public double iBedrooms { get; private set; }
        public double iBathrooms { get; private set; }
        public int iSqFt { get; private set; }
        public int iYrBuilt { get; private set; }
        #endregion
        
        public COJScraper(string url)
        {
            base.URL = url;

            iBedrooms = 0;
            iBathrooms = 0;
            iSqFt = 0;
            iYrBuilt = 0;
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
            iBedrooms = double.Parse(Regex.Match(Bedrooms, @"\d+\.\d+$").Value);
            iBathrooms = double.Parse(Regex.Match(Bathrooms, @"\d+\.\d+$").Value);
            iSqFt = int.Parse(Regex.Match(SqFt, @"\d+$").Value);
            iYrBuilt = int.Parse(Regex.Match(YrBuilt, @"\d+").Value);
        }
    }
}
