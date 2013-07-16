using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForeclosureDataRetriever;

namespace ForeclosureDataRetriever
{
    public partial class Foreclosure : Form
    {
        private List<string> RootLinks { get; set; }
        private string NavigateLink;

        public Foreclosure()
        {
            InitializeComponent();
            RootLinks = new List<string>(){
                "http://apps.coj.net/PAO_PROPERTYSEARCH/Basic/Detail.aspx?RE=",
                "http://apps.coj.net/pao_propertySearch/Leaving.aspx?Destination=PTR&RE=",
                "https://www.rentometer.com/"};
        }

        private void btnLoadCOJ_Click(object sender, EventArgs e)
        {
            NavigateLink = RootLinks[0] + txtCOJURL.Text;
            BrowserWindow.Navigate(new Uri(NavigateLink));
            this.BrowserWindow.DocumentCompleted += 
                new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(COJLinkLoaded);
        }

        private void COJLinkLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
            {
                return;
            }
            
            COJScraper HouseDetails = new COJScraper(NavigateLink);

            HouseDetails.ScrapePage();
            DisplayHouseDetails(HouseDetails);

            this.BrowserWindow.DocumentCompleted -= 
                new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(COJLinkLoaded);
        }

        private void RentMeterLinkLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
            {
                return;
            }

            this.BrowserWindow.Document.GetElementById("address_field").GotFocus +=
                new HtmlElementEventHandler(SendRentOMeterInfo);

            this.BrowserWindow.DocumentCompleted -=
                new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(RentMeterLinkLoaded);
            }

        private void SendRentOMeterInfo(object sender, HtmlElementEventArgs e)
        {
            BrowserWindow.Document.GetElementById("address_field").InnerText = lbl_Address.Text + " 32216";
            
            BrowserWindow.Document.GetElementById("latitude").InnerText = "30.269263";
            BrowserWindow.Document.GetElementById("longitude").InnerText = "-81.57560539999997";

            BrowserWindow.Document.GetElementById("beds").SetAttribute("value", lbl_Bed.Text);

            HtmlElement form = BrowserWindow.Document.GetElementById("search_form");

            if (form != null)
            {
                form.InvokeMember("submit");
            }
        }

        private void DisplayHouseDetails(COJScraper details)
        {
            lbl_Address.Text = BrowserWindow.Document.GetElementById("ctl00_cphBody_lblPrimarySiteAddressLine1").InnerText;
            lbl_Bed.Text = details.iBedrooms.ToString();
            lbl_Bath.Text = details.iBathrooms.ToString();
            lbl_SqFt.Text = details.iSqFt.ToString();
            lbl_YrBuilt.Text = details.iYrBuilt.ToString();
        }

        private void DisplayRentDetails(RentOMeterScraper details)
        {
            lbl_Min.Text = details.iMin.ToString();
            lbl_Max.Text = details.iMax.ToString();
            lbl_Median.Text = details.iMedian.ToString();
            lbl_Rge1.Text = details.iModerateRange;
            lbl_Rge2.Text = details.iHighPricedRange;
        }

        private void btnLoadRentMeter_Click(object sender, EventArgs e)
        {
            BrowserWindow.Navigate(new Uri(RootLinks[2]));

            this.BrowserWindow.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(RentMeterLinkLoaded);
        }

        private void btnGetRentDetails_Click(object sender, EventArgs e)
        {
            RentOMeterScraper RentDetails = new RentOMeterScraper(BrowserWindow.Url.AbsoluteUri);
            RentDetails.ScrapePage();
            DisplayRentDetails(RentDetails);

            btnLoadTaxRecord.Enabled = true;
        }

        private void btnCopyClipboard_Click(object sender, EventArgs e)
        {
            //bedrooms bathrooms sqft yrbuilt rent range
            string clipboard = lbl_Bed.Text + "," + lbl_Bath.Text + "," + lbl_SqFt.Text +
                "," + lbl_YrBuilt.Text + "," + lbl_Rge1.Text;
            Clipboard.SetText(clipboard);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all data
        }

        private void btnTaxRecord_Click(object sender, EventArgs e)
        {
            NavigateLink = "http://apps.coj.net/pao_propertySearch/Leaving.aspx?Destination=PTR&RE=" + txtCOJURL.Text;
            BrowserWindow.Navigate(new Uri(NavigateLink));

            btnCopyClipboard.Enabled = true;
        }

        private void Foreclosure_Resize(object sender, EventArgs e)
        {
            BrowserWindow.Width = this.Width - BrowserWindow.Location.X - 20;
            BrowserWindow.Height = this.Height - BrowserWindow.Location.Y - 10;
        }
    }
}
