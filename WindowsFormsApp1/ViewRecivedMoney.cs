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
    public partial class ViewRecivedMoney : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Invoice.mdb");
        private OleDbCommand cmd;
        private OleDbCommand cmd1;
        private OleDbDataAdapter oleDbDataAdapter;
        private DataTable dt;
        private int selectedRowIndex = 0;
        private int customerId;
        private string selectedBill = "";
        private int CustomerId = 0;
        public ViewRecivedMoney()
        {
            InitializeComponent();
            loadCustomerCombo();
            FactorLookUp.CascadingOwner = CustomerCombo;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            selectedBill = dr.Cells[1].Value.ToString();
        }




        private void CalculateTotalValue(decimal PaidPrice)
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
            label5.Text = (Convert.ToDecimal(label4.Text) - FinalPrice).ToString("N0");
        }


        private void fillGrid(string factorNumber)
        {
            decimal paidprice = 0;

            con.Open();
            oleDbDataAdapter = new OleDbDataAdapter("SELECT BillongNO,PayAmount,IsPayByCheck,CheckDate,CheckNumber FROM  tbl_PayDetail order by BillongNO DESC", con);
            DataSet ds = new DataSet();
            oleDbDataAdapter.Fill(ds, "TblHeaderData");
            var x = ds.Tables["TblHeaderData"];
            // WHERE BillDate BETWEEN '" + StartDate.ToString("MM/dd/yyyy") + "' AND '" + EndDate.ToString("MM/dd/yyyy") + "' 
            con.Close();
            List<ReciveMoney> lst = new List<ReciveMoney>();
            // OleDbDataAdapter.Fill(dt);
            for (var i = 0; i < x.Rows.Count; i++)
            {
                if (x.Rows[i].ItemArray[0] == factorNumber)
                {
                    ReciveMoney item = new ReciveMoney();
                    item.PayPrice = Convert.ToDecimal(x.Rows[i].ItemArray[1]).ToString("N0");
                    item.CheckNumber = x.Rows[i].ItemArray[4].ToString();
                    item.CheckDate = x.Rows[i].ItemArray[3].ToString();
                    item.PayType = Convert.ToBoolean(x.Rows[i].ItemArray[2]) == true ? "چک" : "نقدی";
                    paidprice = paidprice + Convert.ToDecimal(x.Rows[i].ItemArray[1]);
                    lst.Add(item);
                }
            }
            dataGridView1.DataSource = lst;
            CalculateTotalValue( paidprice);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            string factorNumber = this.FactorLookUp.Properties.View.GetFocusedRowCellValue("BillNumber").ToString();//FactorLookUp.EditValue.ToString();
            fillGrid(factorNumber);

        }
        private void loadCustomerCombo()
        {

            con.Open();
            oleDbDataAdapter = new OleDbDataAdapter("SELECT ID, CustomerName, CustomerNationalNumber, CustomerOrg, CustomerPhone,CustomerAddress FROM  tbl_Customers WHERE  IsActive = true  ", con);

            OleDbCommandBuilder ocb = new OleDbCommandBuilder(oleDbDataAdapter);
            dt = new DataTable();
            oleDbDataAdapter.Fill(dt);
            con.Close();

            var lst = new List<CustomerComboboxItem>();
            if (dt.Rows.Count > 0 && dt.Rows != null)
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {

                    CustomerComboboxItem item = new CustomerComboboxItem();
                    item.CustomerName = dt.Rows[i].ItemArray[1].ToString();
                    item.CustomerValue = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                    item.CustomerOrg = dt.Rows[i].ItemArray[3].ToString();
                    lst.Add(item);
                }
            }
            this.CustomerCombo.Properties.DataSource = lst;
            this.CustomerCombo.Properties.DisplayMember = "CustomerName";
            this.CustomerCombo.Properties.ValueMember = "CustomerValue";




        }

        private void loadFactorListForCustomer(int CustomerId)
        {

            con.Open();
            oleDbDataAdapter = new OleDbDataAdapter("SELECT ID, BillNumber, BillDate, BillAmount, Discount, SendPrice,FinalPrice,customerId FROM  tbl_Orders order by BillNumber DESC  ", con);

            DataSet ds = new DataSet();
            oleDbDataAdapter.Fill(ds, "TblHeaderData");
            var x = ds.Tables["TblHeaderData"];
            con.Close();

            List<Factor> lst = new List<Factor>();
            // OleDbDataAdapter.Fill(dt);
            for (var i = 0; i < x.Rows.Count; i++)
            {
                if (Convert.ToInt32(x.Rows[i].ItemArray[7]) == CustomerId)
                {
                    Factor item = new Factor();
                    item.Id = Convert.ToInt32(x.Rows[i].ItemArray[0]);
                    item.BillNumber = x.Rows[i].ItemArray[1].ToString();
                    item.BillDate = Tools.ToShamsiDateString((DateTime)x.Rows[i].ItemArray[2]);
                    item.BillAmount = x.Rows[i].ItemArray[3].ToString();
                    item.Discount = x.Rows[i].ItemArray[4].ToString();
                    item.SendPrice = x.Rows[i].ItemArray[5].ToString();
                    item.FinalPrice = x.Rows[i].ItemArray[6].ToString();
                    lst.Add(item);
                }
            }
            this.FactorLookUp.Properties.DataSource = lst;
            this.FactorLookUp.Properties.DisplayMember = "BillNumber";
            this.FactorLookUp.Properties.ValueMember = "Id";




        }

        private void CustomerCombo_EditValueChanged(object sender, EventArgs e)
        {
            if (CustomerCombo.EditValue != null)
            {

                CustomerId = (int)CustomerCombo.EditValue;
                loadFactorListForCustomer(CustomerId);
            }
            else
            {
                loadCustomerCombo();
            }
        }

        private void FactorLookUp_EditValueChanged(object sender, EventArgs e)
        {
            label4.Text = Convert.ToDecimal(this.FactorLookUp.Properties.View.GetFocusedRowCellValue("FinalPrice").ToString()).ToString("N0");
        }
    }
    public class ReciveMoney
    {
        public string PayType { get; set; }
        public string PayPrice { get; set; }
        public string CheckNumber { get; set; }
        public string CheckDate { get; set; }
    }

}
