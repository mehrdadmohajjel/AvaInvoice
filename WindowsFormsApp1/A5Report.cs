using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Billing
{
    public partial class A5Report : DevExpress.XtraReports.UI.XtraReport
    {
        public A5Report()
        {
            InitializeComponent();
        }

        private void RadifCell_BeforePrint(object sender, CancelEventArgs e)
        {
            try
            {
                XRTableCell cellObj = sender as XRTableCell;
                if (GetCurrentColumnValue("Radif") != null)
                {
                    cellObj.Text = GetCurrentColumnValue("Radif").ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ProductNameCell_BeforePrint(object sender, CancelEventArgs e)
        {
            try
            {
                XRTableCell cellObj = sender as XRTableCell;
                if (GetCurrentColumnValue("ProductName") != null)
                {
                    cellObj.Text = GetCurrentColumnValue("ProductName").ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ProductCountCell_BeforePrint(object sender, CancelEventArgs e)
        {
            try
            {
                XRTableCell cellObj = sender as XRTableCell;
                if (GetCurrentColumnValue("ProductCount") != null)
                {
                    cellObj.Text = GetCurrentColumnValue("ProductCount").ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ProductPriceCell_BeforePrint(object sender, CancelEventArgs e)
        {
            try
            {
                XRTableCell cellObj = sender as XRTableCell;
                if (GetCurrentColumnValue("ProductPrice") != null)
                {
                    cellObj.Text = GetCurrentColumnValue("ProductPrice").ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ProductTotalPriceCell_BeforePrint(object sender, CancelEventArgs e)
        {
            try
            {
                XRTableCell cellObj = sender as XRTableCell;
                if (GetCurrentColumnValue("ProductTotalPrice") != null)
                {
                    cellObj.Text = GetCurrentColumnValue("ProductTotalPrice").ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void headeLogo_BeforePrint(object sender, CancelEventArgs e)
        {
            try
            {
                XRPictureBox cellObj = sender as XRPictureBox;
                if (!string.IsNullOrEmpty(Parameters["LogoUrl"].ToString()))
                {
                    cellObj.ImageUrl = Parameters["LogoUrl"].Value.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FooterLogo_BeforePrint(object sender, CancelEventArgs e)
        {
            try
            {
                XRPictureBox cellObj = sender as XRPictureBox;
                if (!string.IsNullOrEmpty(Parameters["LogoUrl"].ToString()))
                {
                    cellObj.ImageUrl = Parameters["LogoUrl"].Value.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
