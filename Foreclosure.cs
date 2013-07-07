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
        private string BaseCOJURL;

        public Foreclosure()
        {
            InitializeComponent();
            BaseCOJURL = "http://apps.coj.net/PAO_PROPERTYSEARCH/Basic/Detail.aspx?RE=";
        }

        private void btnLoadCOJ_Click(object sender, EventArgs e)
        {
            BaseCOJURL += txtCOJURL.Text;
            webBrowser.Navigate(new Uri(BaseCOJURL));

            btnGetHouseDetails.Enabled = true;
        }

        private void btnSendAddress_Click(object sender, EventArgs e)
        {
            webBrowser.Document.GetElementById("address_field").InnerText
                = lbl_Address.Text + " 32216";

            btnGetRentDetails.Enabled = true;
        }

        private void DisplayHouseDetails(COJScraper details)
        {
            lbl_Address.Text = webBrowser.Document.GetElementById("ctl00_cphBody_lblPrimarySiteAddressLine1").InnerText;
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

        private void btnGetHouseDetails_Click(object sender, EventArgs e)
        {
            COJScraper HouseDetails = new COJScraper(BaseCOJURL);

            HouseDetails.ScrapePage();
            DisplayHouseDetails(HouseDetails);

            btnLoadRentMeter.Enabled = true;
        }

        private void btnLoadRentMeter_Click(object sender, EventArgs e)
        {
            BaseCOJURL = "https://www.rentometer.com/";
            webBrowser.Navigate(new Uri(BaseCOJURL));

            btnSendAddress.Enabled = true;
        }

        private void btnGetRentDetails_Click(object sender, EventArgs e)
        {
            RentOMeterScraper RentDetails = new RentOMeterScraper(webBrowser.Url.AbsoluteUri);
            RentDetails.ScrapePage();
            DisplayRentDetails(RentDetails);

            btnCopyClipboard.Enabled = true;
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
    }
}
