using Billing;
using DevExpress.XtraReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Utility;

namespace WindowsFormsApp1
{
    public partial class ViewBills : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Invoice.mdb");
        private OleDbCommand cmd;
        private OleDbCommand cmd1;
        private OleDbDataAdapter oleDbDataAdapter;
        private DataTable dt;
        private int selectedRowIndex = 0;
        private int customerId;
        private string selectedBill = "";

        public ViewBills()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            selectedBill = dr.Cells[1].Value.ToString();
            simpleButton2.Enabled = true;
            simpleButton1.Enabled = true;
        }




        private void CalculateTotalValue()
        {
            decimal BillAmount = 0;
            decimal SendPrice = 0;
            decimal Discount = 0;
            decimal FinalPrice = 0;
            // factorcountLBL.Text = "تعداد سفارش :" + dataGridView1.Rows.Count.ToString();
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                decimal dis = 0;
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells["Discount"].Value.ToString()) || !string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells["Discount"].Value.ToString()))
                {
                    dis = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Discount"].Value);
                }
                BillAmount = BillAmount + Convert.ToDecimal(dataGridView1.Rows[i].Cells["BillAmount"].Value);
                SendPrice = SendPrice + Convert.ToDecimal(dataGridView1.Rows[i].Cells["SendPrice"].Value);
                Discount = Discount + dis;
                FinalPrice = FinalPrice + Convert.ToDecimal(dataGridView1.Rows[i].Cells["FinalPrice"].Value);
            }
             TotalBillAmountLBL.Text =  BillAmount.ToString();
            TotalSendPriceLBL.Text = SendPrice.ToString();
            TotalDisountLBL.Text = Discount.ToString();
            TotalFinalPriceLBL.Text = FinalPrice.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(selectedBill) || string.IsNullOrWhiteSpace(selectedBill))
            {
                MessageBox.Show("لطفا ابتدا فاکتور را جهت حذف انتخاب کنید", "خطا", MessageBoxButtons.OK);

            }
            else
            {
                DialogResult Drg = MessageBox.Show("شما میخواهید فاکتور" + selectedBill + " را حذف کنید", "حذف فاکتور", MessageBoxButtons.YesNo);
                if (Drg == DialogResult.Yes)
                {
                    cmd = new OleDbCommand();
                    con.Open();
                    OleDbTransaction trans = con.BeginTransaction();
                    try
                    {
                        cmd = new OleDbCommand("DELETE tbl_Orders WHERE BillNumber='" + selectedBill + "'", con);
                        cmd1 = new OleDbCommand("DELETE tbl_OrderDetail WHERE BillNumber='" + selectedBill + "'", con);
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        var sdate = persianDatePicker1.PersianDate.ToString();
                        var startDate = Tools.ConvertToLatinDate(sdate);
                        var edate = persianDatePicker2.PersianDate.ToString();
                        var endDate = Tools.ConvertToLatinDate(edate);

                        fillGrid(startDate, endDate);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        trans.Rollback();
                        con.Close();
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedBill) || string.IsNullOrWhiteSpace(selectedBill))
            {
                MessageBox.Show("لطفا ابتدا فاکتور را جهت پرینت انتخاب کنید", "خطا", MessageBoxButtons.OK);

            }
            else
            {
                PrintFactor(selectedBill);
            }
        }
        private void PrintFactor(string FactorNumber)
        {
            try
            {
                var logoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                A5Report report = new A5Report();
                string factorNumber = "";
                DataTable dt1 = new DataTable();
                con.Open();
                oleDbDataAdapter = new OleDbDataAdapter("SELECT top 1 tbl_Orders.ID, tbl_Orders.BillNumber, tbl_Orders.BillDate, tbl_Orders.BillAmount," +
                    " tbl_Orders.Discount, tbl_Orders.SendPrice,tbl_Orders.FinalPrice" +
                    ",tbl_Customers.CustomerName,tbl_Customers.CustomerNationalNumber,tbl_Customers.CustomerOrg," +
                    "tbl_Customers.CustomerPhone,tbl_Customers.CustomerAddress" +
                    " FROM  tbl_Orders  INNER JOIN tbl_Customers ON tbl_Customers.ID =tbl_Orders.customerId " +
                    "WHERE BillNumber='" + selectedBill + "' order by BillNumber DESC", con);
                DataSet ds = new DataSet();
                oleDbDataAdapter.Fill(ds, "TblHeaderData");
                var x = ds.Tables["TblHeaderData"];
                con.Close();



                con.Open();
                oleDbDataAdapter = new OleDbDataAdapter("Select TOP 1 ID,CompanyName,Code,Tell,Address,LogoUrl FROM tbl_BaseInfo  ", con);
                con.Close();
                OleDbCommandBuilder ocb = new OleDbCommandBuilder(oleDbDataAdapter);
                dt = new DataTable();
                oleDbDataAdapter.Fill(dt);

                //factorNumberLBL.Text = dt.;
                if (dt.Rows.Count != 0)
                {
                    var destiniation = logoPath + @"\Logo\" + dt.Rows[0].ItemArray[5].ToString();

                    report.FindControl("ShopnameCell", true).Text = dt.Rows[0].ItemArray[1].ToString();
                    report.FindControl("FooterShopNameCell", true).Text = dt.Rows[0].ItemArray[1].ToString();
                    report.FindControl("SopTellCell", true).Text = dt.Rows[0].ItemArray[3].ToString();
                    report.FindControl("ShopAddressCell", true).Text = dt.Rows[0].ItemArray[4].ToString();
                    report.Parameters["LogoUrl"].Value = destiniation;
                }





                for (var i = 0; i < x.Rows.Count; i++)
                {


                    report.FindControl("factoNoCell", true).Text = x.Rows[i].ItemArray[1].ToString();
                    factorNumber = x.Rows[i].ItemArray[1].ToString();
                    report.FindControl("BillDateCell", true).Text = Tools.ToShamsiDateString((DateTime)x.Rows[i].ItemArray[2]);
                    report.FindControl("TotalFactorPriceCell", true).Text = x.Rows[i].ItemArray[3].ToString();
                    report.FindControl("DiscountPriceCell", true).Text = x.Rows[i].ItemArray[4].ToString();
                    report.FindControl("SendPriceCell", true).Text = x.Rows[i].ItemArray[5].ToString();
                    report.FindControl("TotalPriceCell", true).Text = x.Rows[i].ItemArray[6].ToString();

                    report.FindControl("CustomerNameCell", true).Text = x.Rows[i].ItemArray[7].ToString();
                    report.FindControl("NationalNumberCell", true).Text = x.Rows[i].ItemArray[8].ToString();
                    report.FindControl("CustomerOrgCell", true).Text = x.Rows[i].ItemArray[9].ToString();
                    report.FindControl("CustomerTellCell", true).Text = x.Rows[i].ItemArray[10].ToString();
                    report.FindControl("CustomerAddressCell", true).Text = x.Rows[i].ItemArray[11].ToString();

                }


                con.Open();
                oleDbDataAdapter = new OleDbDataAdapter("SELECT BillNumber,ProductName,ProdcutID,Price AS ProductPrice,Quantity AS ProductCount,Price*Quantity As ProductTotalPrice   FROM tbl_OrderDetail " +
                    "WHERE BillNumber='" + selectedBill + "' order by BillNumber DESC", con);
                DataSet ds2 = new DataSet();

                oleDbDataAdapter.Fill(ds2, "TblHDetailData");

                var detailData = ds2.Tables["TblHDetailData"];
                DataColumn RadifCol = new DataColumn();
                RadifCol.ColumnName = "Radif";
                detailData.Columns.Add(RadifCol);

                con.Close();




                var Count = 0;
                foreach (DataRow DR in detailData.Rows)
                {
                    Count++;
                    DR["ProductName"] = DR.ItemArray[1].ToString();
                    DR["ProductCount"] = DR.ItemArray[4].ToString();
                    DR["ProductPrice"] = DR.ItemArray[3].ToString();
                    DR["ProductTotalPrice"] = DR.ItemArray[5].ToString();
                    DR["Radif"] = Count;
                }


                report.DataSource = detailData;
                string _FileName = factorNumber + ".pdf";
                //string _path = AppDomain.CurrentDomain.("~/FileBank/CMMS/Temp/") + _FileName;
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + _FileName;
                report.ExportToPdf(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }

        }
        private void fillGrid(DateTime StartDate, DateTime EndDate)
        {



            con.Open();
            oleDbDataAdapter = new OleDbDataAdapter("SELECT ID, BillNumber, BillDate, BillAmount, Discount, SendPrice,FinalPrice,IsPaid FROM  tbl_Orders order by BillNumber DESC", con);
            DataSet ds = new DataSet();
            oleDbDataAdapter.Fill(ds, "TblHeaderData");
            var x = ds.Tables["TblHeaderData"];
            // WHERE BillDate BETWEEN '" + StartDate.ToString("MM/dd/yyyy") + "' AND '" + EndDate.ToString("MM/dd/yyyy") + "' 
            con.Close();
            List<Factor> lst = new List<Factor>();
            // OleDbDataAdapter.Fill(dt);
            for (var i = 0; i < x.Rows.Count; i++)
            {
                if ((DateTime)x.Rows[i].ItemArray[2] >= StartDate && (DateTime)x.Rows[i].ItemArray[2] <= EndDate)
                {
                    Factor item = new Factor();
                    item.Id = Convert.ToInt32(x.Rows[i].ItemArray[0]);
                    item.BillNumber = x.Rows[i].ItemArray[1].ToString();
                    item.BillDate = Tools.ToShamsiDateString((DateTime)x.Rows[i].ItemArray[2]);
                    item.BillAmount = x.Rows[i].ItemArray[3].ToString();
                    item.Discount = x.Rows[i].ItemArray[4].ToString();
                    item.SendPrice = x.Rows[i].ItemArray[5].ToString();
                    item.FinalPrice = x.Rows[i].ItemArray[6].ToString();
                    item.IsPaid = Convert.ToBoolean(x.Rows[i].ItemArray[7]) == true ? "پرداخت شده" : "منتظر پرداخت";
                    lst.Add(item);
                }
            }
            dataGridView1.DataSource = lst;
            CalculateTotalValue();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            var sdate = persianDatePicker1.PersianDate.ToString();
            var startDate = Tools.ConvertToLatinDate(sdate);
            var edate = persianDatePicker2.PersianDate.ToString();
            var endDate = Tools.ConvertToLatinDate(edate);
            fillGrid(startDate, endDate);

        }
    }
    public class Factor
    {
        public int Id { get; set; }
        public string BillNumber { get; set; }
        public string BillDate { get; set; }
        public string BillAmount { get; set; }
        public string Discount { get; set; }
        public string SendPrice { get; set; }
        public string FinalPrice { get; set; }
        public string IsPaid { get; set; }
    }

}
