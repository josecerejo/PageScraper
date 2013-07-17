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
    public class COJScraper
    {
        #region private strings
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Bedrooms { get; private set; }
        public string Bathrooms { get; private set; }
        public string SqFt { get; private set; }
        public string YrBuilt { get; private set; }
        public string RootURL { get; private set; }
        #endregion
        
        public COJScraper()
        {
            RootURL = "http://apps.coj.net/PAO_PROPERTYSEARCH/Basic/Detail.aspx?RE=";
        }

        public void SetProperties(List<string> list)
        {
            Name = list[0];
            Address = list[1];
            YrBuilt = list[3];
            SqFt = list[19];
            Bedrooms = list[24];
            Bathrooms = list[26];
        }
    }
}
