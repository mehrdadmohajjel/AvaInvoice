using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Products : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Invoice.mdb");
        private OleDbCommand cmd;
        private OleDbDataAdapter OleDbDataAdapter;
        private DataTable dt;
        private int selectedRowIndex = 0;
        private int productId;
        public Products()
        {
            InitializeComponent();
        }

        private void fillGrid()
        {
            con.Open();
            OleDbDataAdapter = new OleDbDataAdapter("Select ID,ProductName,ProductCode FROM tbl_Products WHERE IsActive = true ORDER BY CreationDate Desc ", con);
            con.Close();
            OleDbCommandBuilder ocb = new OleDbCommandBuilder(OleDbDataAdapter);
            dt = new DataTable();
            OleDbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void ClearForm()
        {
            productId = 0;
            ProductCodeTXT.Text = "";
            ProductNameTXT.Text = "";
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
            AddBtn.Enabled = true;
            newBtn.Visible = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
            ProductNameTXT.Text = row.Cells[1].Value.ToString();
            ProductCodeTXT.Text = row.Cells[2].Value.ToString();
            productId = Convert.ToInt32(row.Cells[0].Value);
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            AddBtn.Enabled = false;
            newBtn.Visible = true;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var errcount = 0;

            if (string.IsNullOrEmpty(ProductNameTXT.Text) || string.IsNullOrWhiteSpace(ProductNameTXT.Text))
            {
                errcount = errcount + 1;
                MessageBox.Show("لطفا نام محصول را وارد کنید", "خطا", MessageBoxButtons.OK);
            }
            if (string.IsNullOrEmpty(ProductCodeTXT.Text) || string.IsNullOrWhiteSpace(ProductCodeTXT.Text))
            {
                errcount = errcount + 1;

                MessageBox.Show("لطفا کد محصول را وارد کنید", "خطا", MessageBoxButtons.OK);
            }

            if (errcount == 0)
            {
                try
                {
                    con.Open();
                    cmd = new OleDbCommand("INSERT INTO tbl_Products(ProductName,ProductCode,CreationDate,IsActive) Values('" + ProductNameTXT.Text + "','" + ProductCodeTXT.Text + "' ,'" + DateTime.Now + "','1')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    fillGrid();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                finally
                {
                    ClearForm();
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var errcount = 0;

            if (string.IsNullOrEmpty(ProductNameTXT.Text) || string.IsNullOrWhiteSpace(ProductNameTXT.Text))
            {
                errcount = errcount + 1;
                MessageBox.Show("لطفا نام محصول را وارد کنید", "خطا", MessageBoxButtons.OK);
            }
            if (string.IsNullOrEmpty(ProductCodeTXT.Text) || string.IsNullOrWhiteSpace(ProductCodeTXT.Text))
            {
                errcount = errcount + 1;

                MessageBox.Show("لطفا کد محصول را وارد کنید", "خطا", MessageBoxButtons.OK);
            }

            if (errcount == 0)
            {
                try
                {
                    string cmdUpdate = @"UPDATE tbl_Products   
                    set ProductName =  @ProductName,
                        ProductCode =@ProductCode
                    where ID = @Id";

                    OleDbCommand command2 = new OleDbCommand(cmdUpdate, con);
                    command2.Parameters.Add("@ProductName", OleDbType.VarChar);
                    command2.Parameters.Add("@ProductCode", OleDbType.VarChar);
                    command2.Parameters.Add("@Id", OleDbType.Integer);
                    command2.Parameters["@ProductName"].Value = ProductNameTXT.Text;
                    command2.Parameters["@ProductCode"].Value = ProductCodeTXT.Text;
                    command2.Parameters["@Id"].Value = productId;

                    con.Open();
                    command2.ExecuteNonQuery();
                    con.Close();
                    fillGrid();
                    editBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                    AddBtn.Enabled = true;
                    ClearForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (productId == 0)
            {

                MessageBox.Show("حصولی جهت حذف انتخاب نشده است", "خطا", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string cmdUpdate = @"UPDATE tbl_Products   
                    set 
                        isActive =false
                    where ID = @Id";

                    OleDbCommand command2 = new OleDbCommand(cmdUpdate, con);
                    command2.Parameters.Add("@Id", OleDbType.Integer);
                    command2.Parameters["@Id"].Value = productId;

                    con.Open();
                    command2.ExecuteNonQuery();
                    con.Close();
                    fillGrid();
                    editBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                    AddBtn.Enabled = true;
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        private string fillProcudtCode()
        {
            PersianCalendar pc = new PersianCalendar();

            var productCode = "1001";
            con.Open();
            OleDbDataAdapter = new OleDbDataAdapter("Select TOP 1 ProductCode  FROM tbl_Products  ORDER BY ID Desc ", con);
            con.Close();
            OleDbCommandBuilder ocb = new OleDbCommandBuilder(OleDbDataAdapter);
            dt = new DataTable();
            OleDbDataAdapter.Fill(dt);
            //factorNumberLBL.Text = dt.;
            if (dt.Rows.Count != 0)
            {
                var lastNumber = dt.Rows[0].ItemArray[0].ToString();

                productCode =  (Convert.ToInt32(lastNumber)+1).ToString();
               
            }
            else
            {

                productCode =  "1001";
            }
            return productCode;
        }

        private void ProductNameTXT_EditValueChanged(object sender, EventArgs e)
        {
            if (!editBtn.Enabled)
            {
                ProductCodeTXT.Text = fillProcudtCode();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTXT.Text))
            {
                fillGrid();
            }
            else
            {
                con.Open();
                OleDbDataAdapter = new OleDbDataAdapter("SELECT ID, CustomerType, CustomerName, CustomerNationalNumber, " +
                    "CustomerOrg, CustomerPhone," +
                    "CustomerAddress FROM  tbl_Customers " +
                    "WHERE  CustomerName LIKE '%" + searchTXT.Text + "%' " +
                    "OR CustomerNationalNumber= '" + searchTXT.Text + "'" +
                    "OR CustomerOrg= '" + searchTXT.Text + "'", con);
                con.Close();
                OleDbCommandBuilder ocb = new OleDbCommandBuilder(OleDbDataAdapter);
                dt = new DataTable();
                OleDbDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void searchTXT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(searchTXT.Text))
                {
                    fillGrid();
                }
                else
                {
                    con.Open();
                    OleDbDataAdapter = new OleDbDataAdapter("SELECT ID, CustomerType, CustomerName, CustomerNationalNumber, " +
                        "CustomerOrg, CustomerPhone," +
                        "CustomerAddress FROM  tbl_Customers " +
                        "WHERE  CustomerName LIKE '%" + searchTXT.Text + "%' " +
                        "OR CustomerNationalNumber= '" + searchTXT.Text + "'" +
                        "OR CustomerOrg= '" + searchTXT.Text + "'", con);
                    con.Close();
                    OleDbCommandBuilder ocb = new OleDbCommandBuilder(OleDbDataAdapter);
                    dt = new DataTable();
                    OleDbDataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
