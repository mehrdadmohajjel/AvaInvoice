using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Utility;

namespace WindowsFormsApp1
{
    public partial class Pay : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Invoice.mdb");
        private OleDbCommand cmd;
        private OleDbCommand cmd1;
        private OleDbDataAdapter oleDbDataAdapter;
        private OleDbDataAdapter oleDbDataAdapter1;
        private DataTable dt;

        private string SelectedBillNumber = "";
        private string SelectedBillDate = "";
        private string SelectedBillAmount = "";
        private string SelectedDiscount = "";
        private string SelectedSendPrice = "";
        private string SelectedFinalPrice = "";
        private int errcount = 0;
        public int CustomerId { get; set; }

        public Pay()
        {
            InitializeComponent();
            loadCustomerCombo();
            FactorLookUp.CascadingOwner = CustomerCombo;

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

        private void FactorLookUp_EditValueChanged(object sender, EventArgs e)
        {
            FactorNumberLBL.Text  = this.FactorLookUp.Properties.View.GetFocusedRowCellValue("BillNumber").ToString();
            FactorDateLBL.Text = this.FactorLookUp.Properties.View.GetFocusedRowCellValue("BillDate").ToString();
            FactorPriceLBL.Text =  Convert.ToDecimal(this.FactorLookUp.Properties.View.GetFocusedRowCellValue("BillAmount")).ToString("N0");
            DiscountLBL.Text = Convert.ToDecimal(this.FactorLookUp.Properties.View.GetFocusedRowCellValue("Discount").ToString()).ToString("N0");
            SendPriceLBL.Text = Convert.ToDecimal(this.FactorLookUp.Properties.View.GetFocusedRowCellValue("SendPrice").ToString()).ToString("N0");
            FinalPriceLBL.Text = Convert.ToDecimal(this.FactorLookUp.Properties.View.GetFocusedRowCellValue("FinalPrice").ToString()).ToString("N0");
        }

        private void PayRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(PayRadio.Checked)
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
            }
        }

        private void CheckPayRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPayRadio.Checked)
            {
                panel2.Enabled = true;
                panel1.Enabled = false;
            }
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbTransaction trans = con.BeginTransaction();
            try
            {
                cmd = new OleDbCommand("INSERT INTO tbl_Pay(BillongNO,PayDate) " +
                     "Values('" + FactorNumberLBL.Text + "','" + DateTime.Now + "' )", con, trans);

                cmd.ExecuteNonQuery();
                if (PayRadio.Checked)
                {
                    cmd1 = new OleDbCommand("INSERT INTO tbl_PayDetail(BillongNO,PayAmount,IsPayByCheck) " +
                    "Values('" + FactorNumberLBL.Text + "','" + PayPriceLBL.Text.Replace(",", "") + "','" + 0 + "')", con, trans);
                    cmd1.ExecuteNonQuery();

                }
                else
                {
                    var date = persianDatePicker1.PersianDate.ToString();

                    for (var i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        var CheckDate = dataGridView1.Rows[i].Cells["CheckDate"].Value.ToString();
                        var CheckPrice = dataGridView1.Rows[i].Cells["CheckPrice"].Value.ToString().Replace(",","");
                        var CheckNumber = dataGridView1.Rows[i].Cells["CheckNumber"].Value.ToString();
                        cmd1 = new OleDbCommand("INSERT INTO tbl_PayDetail(BillongNO,PayAmount,IsPayByCheck,CheckDate,CheckNumber) " +
                        "Values('" + FactorNumberLBL.Text + "','" + CheckPrice + "','" + 1 + "','" + CheckDate + "','" + CheckNumber + "')", con, trans);
                        cmd1.ExecuteNonQuery();
                    }
                }
                clearFactor();

                trans.Commit();
                MessageBox.Show("پرداخت باموفقیت ثبت شد", "ثبت پرداخت", MessageBoxButtons.OK);



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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            checkAddProduct();
            if (errcount == 0)
            {
                if (string.IsNullOrEmpty(txtUpdate.Text) || string.IsNullOrWhiteSpace(txtUpdate.Text))
                {
                    int row = 0;
                    dataGridView1.Rows.Add();
                    row = dataGridView1.Rows.Count - 1;
                    dataGridView1["CheckPrice", row].Value = Convert.ToDecimal(CheckPriceTXT.Text).ToString("N0"); ;
                    dataGridView1["CheckNumber", row].Value = CheckNumberTXT.Text;
                    dataGridView1["CheckDate", row].Value = persianDatePicker1.PersianDate.ToString();
                    dataGridView1.Refresh();
                    clearFactor();
                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                    }
                }
                else
                {
                    int i;
                    i = Convert.ToInt32(txtUpdate.Text);
                    DataGridViewRow row = dataGridView1.Rows[i - 1];
                    row.Cells["CheckPrice"].Value = CheckPriceTXT.Text;
                    row.Cells["CheckNumber"].Value = CheckNumberTXT.Text;
                    row.Cells["CheckDate"].Value = persianDatePicker1.PersianDate.ToString();
                    clearFactor();

                }
            }
        }


        private void checkAddProduct()
        {
            errcount = 0;
            if (string.IsNullOrEmpty(persianDatePicker1.PersianDate.ToString()) || string.IsNullOrWhiteSpace(persianDatePicker1.PersianDate.ToString()))
            {
                errcount = errcount + 1;
                MessageBox.Show("لطفا  تاریخ را انتخاب کنید", "خطا", MessageBoxButtons.OK);

            }
            else if (string.IsNullOrEmpty(CheckPriceTXT.Text) || string.IsNullOrWhiteSpace(CheckPriceTXT.Text))
            {
                errcount = errcount + 1;
                MessageBox.Show("لطفا مبلغ چک را وارد کنید", "خطا", MessageBoxButtons.OK);

            }
            else if (string.IsNullOrEmpty(CheckNumberTXT.Text) || string.IsNullOrWhiteSpace(CheckNumberTXT.Text))
            {
                errcount = errcount + 1;
                MessageBox.Show("لطفا شماره چک را وارد کنید", "خطا", MessageBoxButtons.OK);

            }
        }
        private void  clearFactor()
        {
            CheckPriceTXT.Text = "";
            CheckNumberTXT.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            CheckPriceTXT.Text = row.Cells["CheckPrice"].Value.ToString();
            CheckNumberTXT.Text = row.Cells["CheckNumber"].Value.ToString();
            //persianDatePicker1.PersianDate = row.Cells["CheckDate"].Value;
            txtUpdate.Text = row.Cells[0].Value.ToString();
            simpleButton3.Enabled = true;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdate.Text) || string.IsNullOrWhiteSpace(txtUpdate.Text))
            {
                MessageBox.Show("جهت حذف لطفا ردیفی را انتخاب کنید", "خطا", MessageBoxButtons.OK);

            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);

                    }
                }
                clearFactor();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PayPriceLBL_TextChanged(object sender, EventArgs e)
        {
            label14.Text = (Convert.ToDecimal(FinalPriceLBL.Text) - Convert.ToDecimal(PayPriceLBL.Text)).ToString("N0");
            PayPriceLBL.Text = string.Format("{0:#,##0}", double.Parse(PayPriceLBL.Text));


        }
    }
}
