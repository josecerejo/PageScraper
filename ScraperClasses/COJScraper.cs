using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;

namespace ForeclosureDataRetriever
{
    public class COJScraper
    {
        #region private strings
        public string RootURL { get; private set; }

        public HtmlDocument CurrentDoc { get; set; }
        public List<string> TableData { get; private set; }
        public HtmlElementCollection Table { get; private set; }
        #endregion
        
        public COJScraper()
        {
            RootURL = "http://apps.coj.net/PAO_PROPERTYSEARCH/Basic/Detail.aspx?RE=";
            TableData = new List<string>();
        }

        public void ScrapePage(HtmlDocument link)
        {
            CurrentDoc = link;

            TableData.Add(CurrentDoc.GetElementById("ctl00_cphBody_repeaterOwnerInformation_ctl00_lblOwnerName").InnerText);
            TableData.Add(CurrentDoc.GetElementById("ctl00_cphBody_lblHeaderPropertyAddress").InnerText);
            ScrapeHTMLTables("buildingsDetailWrapper", "table", 0);
            ScrapeHTMLTables("buildingsDetailWrapper", "table", 1);
            ScrapeHTMLTables("buildingsDetailWrapper", "table", 3);
            RemoveUnneededListElements();
        }

        private void RemoveUnneededListElements()
        {
            TableData.RemoveRange(27, 2);
            TableData.RemoveAt(25);
            TableData.RemoveRange(20, 4);
            TableData.RemoveRange(4, 15);
            TableData.RemoveAt(2);
            //TableData[4] = Regex.Match(TableData[4], @"\d\.\d+^0").Value;
            //TableData[5] = Regex.Match(TableData[5], @"\d\.[0-9]").Value;
        }
        
        private void ScrapeHTMLTables(string _id, string _tagname, int _index)
        {
            Table = CurrentDoc.GetElementById(_id).GetElementsByTagName(_tagname);
            try
            {
                if (Table.Count <= 0) return;
                HtmlElementCollection rows = Table[_index].GetElementsByTagName("td");
                foreach (HtmlElement row in rows)
                {
                    AddToTableData(row.InnerText);
                }
            }
            catch (ArgumentOutOfRangeException exc)
            {
                TableData.Add(exc.Message);
            }
        }

        private void ScrapeHTMLTablesNoID(string _tagname, int _index)
        {
            Table = CurrentDoc.GetElementsByTagName(_tagname);
            try
            {
                if (Table.Count <= 0) return;
                HtmlElementCollection rows = Table[_index].GetElementsByTagName("td");
                foreach (HtmlElement row in rows)
                {
                    AddToTableData(row.InnerText);
                }
            }
            catch (ArgumentOutOfRangeException exc)
            {
                TableData.Add(exc.Message);
            }
        }

        private void AddToTableData(string scraped_text)
        {
            if (!String.IsNullOrEmpty(scraped_text) && !String.IsNullOrWhiteSpace(scraped_text))
            {
                TableData.Add(scraped_text);
            }
        }
    }
}
