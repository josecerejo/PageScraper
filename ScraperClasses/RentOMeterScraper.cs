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
        private string ModerateRange;
        private string HighPricedRange;
        #endregion

        #region public integers
        public int iMin { get; private set; }
        public int iMax { get; private set; }
        public int iMedian { get; private set; }
        public string iModerateRange { get; private set; }
        public string iHighPricedRange { get; private set; }
        #endregion

        public RentOMeterScraper(string url)
        {
            base.URL = url;

            iMin = 0;
            iMax = 0;
            iMedian = 0;
            iModerateRange = "";
            iHighPricedRange = "";
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
            Min = Regex.Match(base.URLData, @"min: \d+").Value;
            Max = Regex.Match(base.URLData, @"max: \d+").Value;
            ModerateRange = Regex.Match(base.URLData, @"greenTo: \d+").Value;
            HighPricedRange = Regex.Match(base.URLData, @"redFrom: \d+").Value;
        }

        public override void ParseStrings()
        {
            iMin = int.Parse(Regex.Match(Min, @"\d+").Value);
            iMax = int.Parse(Regex.Match(Max, @"\d+").Value);
            iMedian = (int)((iMax - iMin) / 2)+ iMin;
            iModerateRange = iMin.ToString() + " - " + Regex.Match(ModerateRange, @"\d+").Value;
            iHighPricedRange = Regex.Match(HighPricedRange, @"\d+").Value + " - " + iMax.ToString();
        }
    }
}
