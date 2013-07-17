﻿using System;
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
                "http://fl-duval-taxcollector.governmax.com",
                "https://www.rentometer.com/"};
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            NavigateLink = RootLinks[0] + txtCOJURL.Text;
            BrowserWindow.Navigate(new Uri(NavigateLink));
            BrowserWindow.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(ScrapeCOJAfterLoading);
        }

        private void LoadRentOMeterPage(object sender, EventArgs e)
        {
            BrowserWindow.Navigate(new Uri(RootLinks[2]));
            BrowserWindow.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(RentMeterLinkLoaded);
        }

        private void ScrapeCOJAfterLoading(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
            {
                return;
            }
            
            COJScraper HouseDetails = new COJScraper(NavigateLink);
            DisplayHouseDetails(HouseDetails);

            BrowserWindow.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(ScrapeCOJAfterLoading);
        }

        private void RentMeterLinkLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
            {
                return;
            }

            BrowserWindow.Document.GetElementById("address_field").GotFocus +=
                new HtmlElementEventHandler(SetElementData);

            BrowserWindow.DocumentCompleted -= 
                new WebBrowserDocumentCompletedEventHandler(RentMeterLinkLoaded);
            }

        private void SetElementData(object sender, HtmlElementEventArgs e)
        {
            BrowserWindow.Document.GetElementById("address_field").InnerText = lbl_Address.Text + " 32216";
            BrowserWindow.Document.GetElementById("latitude").InnerText = "30.269263";
            BrowserWindow.Document.GetElementById("longitude").InnerText = "-81.57560539999997";
            BrowserWindow.Document.GetElementById("beds").SetAttribute("value", lbl_Bed.Text);

            SubmitFormData();

            BrowserWindow.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(ScrapeRentDetails);
        }

        private void SubmitFormData()
        {
            HtmlElement form = BrowserWindow.Document.GetElementById("search_form");

            if (form != null)
            {
                form.InvokeMember("submit");
            }

            BrowserWindow.Document.GetElementById("address_field").GotFocus -=
                new HtmlElementEventHandler(SetElementData);
        }

        private void DisplayHouseDetails(COJScraper details)
        {
            lbl_Address.Text = BrowserWindow.Document.GetElementById("ctl00_cphBody_lblPrimarySiteAddressLine1").InnerText;
            lbl_Bed.Text = details.Bedrooms;
            lbl_Bath.Text = details.Bathrooms;
            lbl_SqFt.Text = details.SqFt;
            lbl_YrBuilt.Text = details.YrBuilt;
        }

        private void ScrapeRentDetails(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            RentOMeterScraper RentDetails = new RentOMeterScraper(BrowserWindow.Url.AbsoluteUri);
            DisplayRentDetails(RentDetails);
            BrowserWindow.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(ScrapeRentDetails);
        }
        
        private void DisplayRentDetails(RentOMeterScraper details)
        {
            lbl_Min.Text = details.iMin.ToString();
            lbl_Max.Text = details.iMax.ToString();
            lbl_Median.Text = details.iMedian.ToString();
            lbl_Rge1.Text = details.iModerateRange;
            lbl_Rge2.Text = details.iHighPricedRange;
        }

        private void LoadAppraiserPage(object sender, EventArgs e)
        {
            NavigateLink = RootLinks[1] + txtCOJURL.Text;
            BrowserWindow.Navigate(new Uri(NavigateLink));
            //BrowserWindow.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(AppraiserLinkLoaded);
        }

        private void AppraiserLinkLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

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
    }
}
