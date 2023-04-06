using Billing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApp1.Utility;

namespace WindowsFormsApp1
{
    public partial class NewBill : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Invoice.mdb");
        private OleDbCommand cmd;
        private OleDbCommand cmd1;
        private OleDbDataAdapter OleDbDataAdapter;
        private OleDbDataAdapter OleDbDataAdapter1;
        private DataTable dt;
        private int selectedRowIndex = 0;
        private int productId;
        private int errcount = 0;
        private string directory = AppDomain.CurrentDomain.BaseDirectory;
        private decimal discount = 0;
        private decimal SentPrice = 0;
        private decimal factorprice = 0;
        private bool CustomerType = false;
        private int customerId = 0;
        public NewBill()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            checkAddProduct();
            if (errcount == 0)
            {
                if (string.IsNullOrEmpty(txtUpdate.Text) || string.IsNullOrWhiteSpace(txtUpdate.Text))
                {
                    int row = 0;
                    dataGridView1.Rows.Add();
                    row = dataGridView1.Rows.Count - 1;
                    dataGridView1["dataGridViewTextBoxColumn7", row].Value = productCombo.Text;
                    dataGridView1["dataGridViewTextBoxColumn9", row].Value = Convert.ToDecimal(priceTXT.Text).ToString("N0");
                    dataGridView1["dataGridViewTextBoxColumn8", row].Value = countTXT.Text;
                    dataGridView1["dataGridViewTextBoxColumn10", row].Value = Convert.ToDecimal(totalPriceTXT.Text).ToString("N0");
                    dataGridView1["dataGridViewTextBoxColumn11", row].Value = Convert.ToDecimal(factorNumberLBL.Text).ToString("N0");
                    dataGridView1["ProductIdCol", row].Value = productCombo.EditValue;

                    dataGridView1.Refresh();
                    ClearFActorHeader();
                    productCombo.Focus();
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
                    row.Cells["dataGridViewTextBoxColumn7"].Value = productCombo.Text;
                    row.Cells["dataGridViewTextBoxColumn9"].Value = Convert.ToDecimal(priceTXT.Text).ToString("N0");
                    row.Cells["dataGridViewTextBoxColumn8"].Value = countTXT.Text;
                    row.Cells["dataGridViewTextBoxColumn10"].Value = Convert.ToDecimal(totalPriceTXT.Text).ToString("N0");
                    row.Cells["dataGridViewTextBoxColumn11"].Value = Convert.ToDecimal(factorNumberLBL.Text).ToString("N0");
                    row.Cells["ProductIdCol"].Value = productCombo.EditValue;
                    ClearFActorHeader();
                    productCombo.Focus();

                }
            }
            TotalFactorSum();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
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
                ClearFActorHeader();

                TotalFactorSum();
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("برای ثبت فاکتور باید حداقل یک ردیف اضافه کنید", "خطا", MessageBoxButtons.OK);

            }
            else
            {
                con.Open();

                OleDbTransaction trans = con.BeginTransaction();

                try
                {
                    var facttornumber = factorNumberLBL.Text;
                    var date = persianDatePicker1.PersianDate.ToString();
                    var factorDate = Tools.ConvertToLatinDate(date);
                    customerId = Convert.ToInt32(CustomerCombo.EditValue);
                    cmd = new OleDbCommand("INSERT INTO tbl_Orders(BillNumber,BillDate,BillAmount,Discount,SendPrice,FinalPrice,IsPaid,customerId) " +
                        "Values('" + factorNumberLBL.Text + "','" + factorDate + "' ,'" + TotalPayTXT.Text + "','" + DiscountTXT.Text + "','" + SendPriceTXT.Text + "','" + FinalPriceTXT.Text + "', '0','" + customerId + "')", con, trans);
                    cmd.ExecuteNonQuery();
                    for (var i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        var productname = dataGridView1.Rows[i].Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                        var prodcutid = Convert.ToInt32(dataGridView1.Rows[i].Cells["ProductId"].Value);
                        var price = dataGridView1.Rows[i].Cells["dataGridViewTextBoxColumn9"].Value.ToString();
                        var qty = dataGridView1.Rows[i].Cells["dataGridViewTextBoxColumn8"].Value.ToString();
                        cmd1 = new OleDbCommand("INSERT INTO tbl_OrderDetail(BillNumber,ProductName,ProdcutID,Price,Quantity) " +
                        "Values('" + factorNumberLBL.Text + "','" + productname + "','" + prodcutid + "','" + price + "','" + qty + "')", con, trans);
                        cmd1.ExecuteNonQuery();
                    }
                    ClearFActorHeader();
                    result = true;
                    MessageBox.Show("فاکتور باموفقیت ثبت شد", "ثبت فاکتور", MessageBoxButtons.OK);

                    trans.Commit();

                    if (result)
                    {
                        DialogResult Drg = MessageBox.Show(" آیا شما میخواهید فاکتور به شماره " + facttornumber + " را چاپ کنید ", "چاپ فاکتور", MessageBoxButtons.YesNo);
                        if (Drg == DialogResult.Yes)
                        {
                            PrintFactor(facttornumber);
                        }
                    }
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

        private void NewBill_Load(object sender, EventArgs e)
        {
            factorNumberLBL.Text = fillFactorNumber();
            loadProductCombo();
            loadCustomerCombo();

        }
        private void loadProductCombo()
        {




            con.Open();
            OleDbDataAdapter = new OleDbDataAdapter("Select ID,ProductName,ProductCode FROM tbl_Products WHERE IsActive = true ORDER BY CreationDate Desc ", con);
            OleDbCommandBuilder ocb = new OleDbCommandBuilder(OleDbDataAdapter);
            dt = new DataTable();
            OleDbDataAdapter.Fill(dt);
            con.Close();

            var lst = new List<ComboboxItem>();
            if (dt.Rows.Count > 0 && dt.Rows != null)
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {

                    ComboboxItem item = new ComboboxItem();
                    item.ProductName = dt.Rows[i].ItemArray[1].ToString();
                    item.ProductValue = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                    lst.Add(item);
                }
            }
            this.productCombo.Properties.DataSource = lst;
            this.productCombo.Properties.DisplayMember = "ProductName";
            this.productCombo.Properties.ValueMember = "ProductValue";



        }

        private string fillFactorNumber()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dtime = DateTime.Now;
            string Year = pc.GetYear(dtime).ToString();
            string Month = pc.GetMonth(dtime).ToString().Length == 1 ? "0" + pc.GetMonth(dtime).ToString() : pc.GetMonth(dtime).ToString();

            var factorNumber = "";
            con.Open();
            OleDbDataAdapter = new OleDbDataAdapter("Select TOP 1 BillNumber  FROM tbl_Orders  ORDER BY ID Desc ", con);
            con.Close();
            OleDbCommandBuilder ocb = new OleDbCommandBuilder(OleDbDataAdapter);
            dt = new DataTable();
            OleDbDataAdapter.Fill(dt);
            //factorNumberLBL.Text = dt.;
            if (dt.Rows.Count != 0)
            {
                var lastNumber = dt.Rows[0].ItemArray[0].ToString();
                var lastfactormonth = lastNumber.Substring(3, 2);
                if (lastfactormonth == Month)
                {
                    factorNumber = (Convert.ToInt64(lastNumber) + 1).ToString();
                }
                else
                {
                    factorNumber = Year.Substring(1, 3) + Month + "001";
                }
            }
            else
            {

                factorNumber = Year.Substring(1, 3) + Month + "001";
            }
            return factorNumber;
        }

        private void loadCustomerCombo()
        {

            con.Open();
            OleDbDataAdapter = new OleDbDataAdapter("SELECT ID, CustomerName, CustomerNationalNumber, CustomerOrg, CustomerPhone,CustomerAddress FROM  tbl_Customers WHERE  IsActive = true  ", con);

            OleDbCommandBuilder ocb = new OleDbCommandBuilder(OleDbDataAdapter);
            dt = new DataTable();
            OleDbDataAdapter.Fill(dt);
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
        private void checkAddProduct()
        {
            errcount = 0;
            if (string.IsNullOrEmpty(productCombo.Text) || string.IsNullOrWhiteSpace(productCombo.Text))
            {
                errcount = errcount + 1;
                MessageBox.Show("لطفا  محصول را انتخاب کنید", "خطا", MessageBoxButtons.OK);

            }
            else if (string.IsNullOrEmpty(countTXT.Text) || string.IsNullOrWhiteSpace(countTXT.Text))
            {
                errcount = errcount + 1;
                MessageBox.Show("لطفا مقدار محصول را انتخاب کنید", "خطا", MessageBoxButtons.OK);

            }
            else if (string.IsNullOrEmpty(priceTXT.Text) || string.IsNullOrWhiteSpace(priceTXT.Text))
            {
                errcount = errcount + 1;
                MessageBox.Show("لطفا قیمت محصول را انتخاب کنید", "خطا", MessageBoxButtons.OK);

            }
        }
        private void ClearFActorHeader()
        {
            totalPriceTXT.Text = "";
            priceTXT.Text = "";
            countTXT.Text = "";
            productCombo.Clear();
            simpleButton1.Image = System.Drawing.Image.FromFile(directory + @"/icon/add_4px.png"); ;

        }
        private void TotalFactorSum()
        {
            decimal sum = 0;
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells["dataGridViewTextBoxColumn10"].Value);
            }
            TotalPayTXT.Text = sum.ToString("N0");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = 0;
            i = e.RowIndex;

            simpleButton1.Image = System.Drawing.Image.FromFile(directory + @"/icon/dit_property.png"); ;

            DataGridViewRow row = dataGridView1.Rows[i];
            productCombo.Text = row.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
            countTXT.Text = row.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
            priceTXT.Text = row.Cells["dataGridViewTextBoxColumn9"].Value.ToString();
            totalPriceTXT.Text = row.Cells["dataGridViewTextBoxColumn10"].Value.ToString();
            factorNumberLBL.Text = row.Cells["dataGridViewTextBoxColumn11"].Value.ToString();
            txtUpdate.Text = row.Cells["dataGridViewTextBoxColumn6"].Value.ToString();

        }

        private void DiscountTXT_Leave(object sender, EventArgs e)
        {
            calcfinalPrice();

        }

        private void SendPriceTXT_Leave(object sender, EventArgs e)
        {
            calcfinalPrice();

        }
        private void calcfinalPrice()
        {
            if (!string.IsNullOrEmpty(TotalPayTXT.Text) || !string.IsNullOrWhiteSpace(TotalPayTXT.Text))
            {
                if (!string.IsNullOrEmpty(SendPriceTXT.Text) || !string.IsNullOrWhiteSpace(SendPriceTXT.Text))
                {
                    SentPrice = Convert.ToDecimal(SendPriceTXT.Text);
                }
                if (!string.IsNullOrEmpty(DiscountTXT.Text) || !string.IsNullOrWhiteSpace(DiscountTXT.Text))
                {
                    discount = Convert.ToDecimal(DiscountTXT.Text);
                }

            }
            factorprice = Convert.ToDecimal(TotalPayTXT.Text);
            FinalPriceTXT.Text = ((factorprice + SentPrice) - discount).ToString("N0");
        }

        private void TotalPayTXT_TextChanged(object sender, EventArgs e)
        {
            calcfinalPrice();

        }
        private void PrintFactor(string FactorNumber)
        {
            try
            {
                var logoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                OleDbDataAdapter oleDbDataAdapter;

                A5Report report = new A5Report();
                string factorNumber = "";
                DataTable dt1 = new DataTable();
                con.Open();
                oleDbDataAdapter = new OleDbDataAdapter("SELECT top 1 tbl_Orders.ID, tbl_Orders.BillNumber, tbl_Orders.BillDate, tbl_Orders.BillAmount," +
                    " tbl_Orders.Discount, tbl_Orders.SendPrice,tbl_Orders.FinalPrice" +
                    ",tbl_Customers.CustomerName,tbl_Customers.CustomerNationalNumber,tbl_Customers.CustomerOrg," +
                    "tbl_Customers.CustomerPhone,tbl_Customers.CustomerAddress" +
                    " FROM  tbl_Orders  INNER JOIN tbl_Customers ON tbl_Customers.ID =tbl_Orders.customerId " +
                    "WHERE BillNumber='" + FactorNumber + "' order by BillNumber DESC", con);
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
                            "WHERE BillNumber='" + FactorNumber + "' order by BillNumber DESC", con);
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

        private void countTXT_EditValueChanged(object sender, EventArgs e)
            {
            if (!string.IsNullOrEmpty(priceTXT.Text) && !string.IsNullOrEmpty(countTXT.Text))
            {
                totalPriceTXT.Text = (Convert.ToDecimal(countTXT.Text) * Convert.ToDecimal(priceTXT.Text)).ToString();
            }
        }

        private void priceTXT_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(priceTXT.Text) && !string.IsNullOrEmpty(countTXT.Text))
            {
                totalPriceTXT.Text = (Convert.ToDecimal(countTXT.Text) * Convert.ToDecimal(priceTXT.Text)).ToString("N0");
                priceTXT.Text = string.Format("{0:#,##0}", double.Parse(priceTXT.Text));

            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void SendPriceTXT_TextChanged(object sender, EventArgs e)
        {
            calcfinalPrice();
        }

        private void DiscountTXT_TextChanged(object sender, EventArgs e)
        {
            calcfinalPrice();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value =(e.RowIndex+1).ToString();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            productCombo.Text = row.Cells[1].Value.ToString();
            countTXT.Text = row.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
            priceTXT.Text = row.Cells["dataGridViewTextBoxColumn9"].Value.ToString();
            totalPriceTXT.Text = row.Cells["dataGridViewTextBoxColumn10"].Value.ToString();
            txtUpdate.Text = row.Cells[0].Value.ToString();
        }

        private void SendPriceTXT_TextChanged_1(object sender, EventArgs e)
        {
            calcfinalPrice();
        }

        private void DiscountTXT_TextChanged_1(object sender, EventArgs e)
        {
            calcfinalPrice();

        }
    }

    public class ComboboxItem
    {
        public string ProductName { get; set; } = "";
        public int ProductValue { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }

    public class CustomerComboboxItem
    {
        public string CustomerName { get; set; } = "";
        public string CustomerOrg { get; set; } = "";
        public int CustomerValue { get; set; }

        public override string ToString()
        {
            return CustomerName;
        }
    }
}
