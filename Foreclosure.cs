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
        public Foreclosure()
        {
            InitializeComponent();
        }

        private void btnGetHouseDetails_Click(object sender, EventArgs e)
        {
            string BaseCOJURL = "http://apps.coj.net/PAO_PROPERTYSEARCH/Basic/Detail.aspx?RE=";

            BaseCOJURL += txtCOJURL.Text;
            COJScraper HouseDetails = new COJScraper(BaseCOJURL);

            HouseDetails.ScrapePage();
            DisplayHouseDetails(HouseDetails);
        }

        private void btnGetRentResults_Click(object sender, EventArgs e)
        {
            RentOMeterScraper RentDetails = new RentOMeterScraper(txtRentURL.Text);
            RentDetails.ScrapePage();
            DisplayRentDetails(RentDetails);
        }

        private void DisplayHouseDetails(COJScraper details)
        {
            lblBed.Text = "Bedrooms: " + details.iBedrooms.ToString();
            lblBath.Text = "Bathrooms: " + details.iBathrooms.ToString();
            lblSqFt.Text = "SqFt: " + details.iSqFt.ToString();
            lblYrBuilt.Text = "Year Built: " + details.iYrBuilt.ToString();
        }

        private void DisplayRentDetails(RentOMeterScraper details)
        {
            lblMin.Text = "Min: " + details.iMin.ToString();
            lblMax.Text = "Max: " + details.iMax.ToString();
        }
    }
}
