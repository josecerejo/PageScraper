using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
//using System.Text.RegularExpressions;
using System.Web;
using System.Net;
using System.IO;

namespace ForeclosureDataRetriever
{
    public class RentOMeterScraper
    {
        #region private strings
        protected string RootURL;
        protected string URLData;

        private string Min;
        private string Max;
        private string ModerateRange;
        private string HighPricedRange;
        #endregion

        public RentOMeterScraper(string url)
        {
            RootURL = url;
        }

        public virtual void ScrapePage()
        {
            RetrieveURLData();
        }

        private void RetrieveURLData()
        {
            WebResponse objResponse;
            WebRequest objRequest = System.Net.HttpWebRequest.Create(RootURL);

            objResponse = objRequest.GetResponse();

            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                URLData = sr.ReadToEnd();
                sr.Close();
            }
        }

        public virtual void SetProperties()
        {
        }
    }
}
