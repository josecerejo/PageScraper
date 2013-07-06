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
    public class Scraper
    {
        #region private strings
        protected string URL;
        protected string URLData;
        #endregion

        public Scraper()
        {
        }

        public virtual void ScrapePage()
        {
            RetrieveURLData();
        }

        private void RetrieveURLData()
        {
            WebResponse objResponse;
            WebRequest objRequest = System.Net.HttpWebRequest.Create(URL);

            objResponse = objRequest.GetResponse();

            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                URLData = sr.ReadToEnd();
                sr.Close();
            }
        }

        public virtual void SetStringProperties()
        {

        }

        public virtual void ParseStrings()
        {
        }
    }
}
