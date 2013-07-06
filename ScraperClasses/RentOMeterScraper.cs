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
    public class RentOMeterScraper : Scraper
    {
        #region private strings
        private string Min;
        private string Max;
        #endregion

        #region public integers
        public int iMin { get; private set; }
        public int iMax { get; private set; }
        #endregion

        public RentOMeterScraper(string url)
        {
            base.URL = url;

            iMin = 0;
            iMax = 0;
        }

        public override void ScrapePage()
        {
            base.ScrapePage();
            SetStringProperties();
            ParseStrings();
        }

        public override void SetStringProperties()
        {
            Min = Regex.Match(base.URLData, @"min: \d+").Value;
            Max = Regex.Match(base.URLData, @"max: \d+").Value;
        }

        public override void ParseStrings()
        {
            iMin = int.Parse(Regex.Match(Min, @"\d+").Value);
            iMax = int.Parse(Regex.Match(Max, @"\d+").Value);
        }
    }
}
