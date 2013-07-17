using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Net;
using System.IO;

namespace ForeclosureDataRetriever
{
    public class RentOMeterScraper
    {
        #region private strings
        public string RootURL {get; private set;}
        private string ActualURL { get; set; }
        private string URLData;

        private string Min;
        private string Max;
        private string ModerateRange;
        private string HighPricedRange;
        #endregion

        public RentOMeterScraper()
        {
            RootURL = "https://www.rentometer.com/";
        }

        public virtual void ScrapePage(string url)
        {
            ActualURL = url;
            RetrieveURLData();
            SetStringProperties();
            ParseStrings();
        }

        private void RetrieveURLData()
        {
            WebResponse objResponse;
            WebRequest objRequest = System.Net.HttpWebRequest.Create(ActualURL);

            objResponse = objRequest.GetResponse();

            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                URLData = sr.ReadToEnd();
                sr.Close();
            }
        }

        public void SetStringProperties()
        {
            Min = Regex.Match(URLData, @"min: \d+").Value;
            Max = Regex.Match(URLData, @"max: \d+").Value;
            ModerateRange = Regex.Match(URLData, @"greenTo: \d+").Value;
            HighPricedRange = Regex.Match(URLData, @"redFrom: \d+").Value;
        }

        public void ParseStrings()
        {
            Min = Regex.Match(Min, @"\d+").Value;
            Max = Regex.Match(Max, @"\d+").Value;
            ModerateRange = Regex.Match(ModerateRange, @"\d+").Value;
            HighPricedRange = Regex.Match(HighPricedRange, @"\d+").Value;
        }
    }
}
