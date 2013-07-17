using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeclosureDataRetriever
{
    public partial class Foreclosure : Form
    {
        private List<string> RootLinks { get; set; }
        private string RE_Number { get; set; }
        private string NavigateLink;
        public List<string> TableData { get; private set; }
        public HtmlElementCollection Table { get; private set; }

        private COJScraper COJ;
        private RentOMeterScraper ROM;

        public Foreclosure()
        {
            InitializeComponent();
            RE_Number = "1545031066";
            COJ = new COJScraper();
            ROM = new RentOMeterScraper();

                //http://fl-duval-taxcollector.governmax.com
            TableData = new List<string>();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //add data check for listbox
            //add listbox items to new list
            //create results list
            //create page objects, containing:
                //root link
                //scrape variables
                //scrape method
            //method to load and scrape each page
                //send results to list
            //display results in results list box

            BrowserWindow.Navigate(new Uri(COJ.RootURL + RE_Number));
            BrowserWindow.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(ScrapeCOJAfterLoading);

        }

        #region COJ
        private void ScrapeCOJAfterLoading(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ScrapeNameAndAddress();
            ScrapeHTMLTables("buildingsDetailWrapper", "table", 0);
            ScrapeHTMLTables("buildingsDetailWrapper", "table", 1);
            ScrapeHTMLTables("buildingsDetailWrapper", "table", 3);
            COJ.SetProperties(TableData);
            
            BrowserWindow.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(ScrapeCOJAfterLoading);
            LoadRentOMeterPage();
        }

        private void ScrapeNameAndAddress()
        {
            TableData.Add(BrowserWindow.Document.GetElementById("ctl00_cphBody_repeaterOwnerInformation_ctl00_lblOwnerName").InnerText);
            TableData.Add(BrowserWindow.Document.GetElementById("ctl00_cphBody_lblHeaderPropertyAddress").InnerText);
        }

        private void ScrapeHTMLTables(string _id, string _tagname, int _index)
        {
            Table = BrowserWindow.Document.GetElementById(_id).GetElementsByTagName(_tagname);
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
        #endregion

        #region RentOMeter
        private void LoadRentOMeterPage()
        {
            BrowserWindow.Navigate(new Uri(ROM.RootURL));
            BrowserWindow.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(RentMeterLinkLoaded);
        }

        private void RentMeterLinkLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
            {
                return;
            }

            BrowserWindow.Document.GetElementById("address_field").GotFocus +=
                new HtmlElementEventHandler(SetFormData);

            BrowserWindow.DocumentCompleted -= 
                new WebBrowserDocumentCompletedEventHandler(RentMeterLinkLoaded);
            }

        private void SetFormData(object sender, HtmlElementEventArgs e)
        {
            BrowserWindow.Document.GetElementById("address_field").InnerText = COJ.Address + " 32216";
            BrowserWindow.Document.GetElementById("latitude").InnerText = "30.269263";
            BrowserWindow.Document.GetElementById("longitude").InnerText = "-81.57560539999997";
            //UPDATE AFTER FIXING THE REGULAR EXPRESSION
            BrowserWindow.Document.GetElementById("beds").SetAttribute("value", "3");
            
            SubmitForm();

            BrowserWindow.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(ScrapeRentDetails);
        }

        private void SubmitForm()
        {
            HtmlElement form = BrowserWindow.Document.GetElementById("search_form");

            if (form != null)
            {
                form.InvokeMember("submit");
            }

            BrowserWindow.Document.GetElementById("address_field").GotFocus -=
                new HtmlElementEventHandler(SetFormData);
        }

        private void ScrapeRentDetails(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ROM.ScrapePage(BrowserWindow.Url.AbsoluteUri);
            BrowserWindow.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(ScrapeRentDetails);
        }
        #endregion

        #region Appraiser
        private void LoadAppraiserPage(object sender, EventArgs e)
        {
            NavigateLink = RootLinks[1] + lstRE.Text[0].ToString();
            BrowserWindow.Navigate(new Uri(NavigateLink));
            //BrowserWindow.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(AppraiserLinkLoaded);
        }

        private void AppraiserLinkLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        #endregion

        #region DisplayCurrentDetails
        private void DisplayHouseDetails(COJScraper details)
        {
            lbl_Address.Text = BrowserWindow.Document.GetElementById("ctl00_cphBody_lblPrimarySiteAddressLine1").InnerText;
            lbl_Bed.Text = details.Bedrooms;
            lbl_Bath.Text = details.Bathrooms;
            lbl_SqFt.Text = details.SqFt;
            lbl_YrBuilt.Text = details.YrBuilt;
        }

        private void DisplayRentDetails(RentOMeterScraper details)
        {
            //lbl_Min.Text = details.iMin.ToString();
            //lbl_Max.Text = details.iMax.ToString();
            //lbl_Median.Text = details.iMedian.ToString();
            //lbl_Rge1.Text = details.iModerateRange;
            //lbl_Rge2.Text = details.iHighPricedRange;
        }
        #endregion

        #region Misc
        private void btnCopyClipboard_Click(object sender, EventArgs e)
        {
            //bedrooms bathrooms sqft yrbuilt rent range
            string clipboard = lbl_Bed.Text + "," + lbl_Bath.Text + "," + lbl_SqFt.Text +
                "," + lbl_YrBuilt.Text + "," + lbl_Rge1.Text;
            Clipboard.SetText(clipboard);
        }

        private void Foreclosure_Resize(object sender, EventArgs e)
        {
            BrowserWindow.Width = this.Width - BrowserWindow.Location.X - 20;
            BrowserWindow.Height = this.Height - BrowserWindow.Location.Y - 10;
        }
        #endregion
    }
}
