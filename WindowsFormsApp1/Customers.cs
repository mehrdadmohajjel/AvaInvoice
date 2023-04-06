using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Customers : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Invoice.mdb");
        private OleDbCommand cmd;
        private OleDbDataAdapter OleDbDataAdapter;
        private DataTable dt;
        private int selectedRowIndex = 0;
        private int customerId;
        private bool Type = false;
        public Customers()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonRadio.Checked)
            {
                CustomerOrgTXT.Enabled = false;
                label2.Text = "کد ملی";
                Type = false;
            }
        }

        private void OrgRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (OrgRadio.Checked)
            {
                CustomerOrgTXT.Enabled = true;
                label2.Text = "شناسه ملی";
                Type = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (checkValidation(Type) == 0)
            {
                try
                {
                    var orgname = "";
                    int ctype = 0;
                    if (Type)
                    {
                        orgname = CustomerOrgTXT.Text;
                        ctype = 1;
                    }
                    con.Open();
                    cmd = new OleDbCommand("INSERT INTO tbl_Customers(CustomerType, CustomerName, CustomerNationalNumber, CustomerOrg, CustomerPhone,CustomerAddress,IsActive) Values('" + ctype + "','" + CustomerNameTXT.Text + "' ,'" + CustomerNationalNumberTXT.Text + "','" + orgname + "','" + CustomerPhoneTXT.Text + "','" + CustomerAddressTXT.Text + "','1')", con);
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
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (checkValidation(Type) == 0)
            {
                try
                {
                    //string cmdUpdate = @"UPDATE tbl_Customers   
                    //set 
                    //    CustomerName = @CustomerName

                    //where tbl_Customers.ID = @Id";
                    ////CustomerNationalNumber = @CustomerNationalNumber,
                    ////    CustomerOrg = @CustomerOrg,
                    ////    CustomerPhone = @CustomerPhone,
                    ////    CustomerAddress = @CustomerAddress,
                    ////CustomerType = @CustomerType,
                    //OleDbCommand command2 = new OleDbCommand(cmdUpdate, con);
                    //command2.Parameters.Add("@CustomerType", OleDbType.Integer);
                    //command2.Parameters.Add("@CustomerName", OleDbType.VarChar);
                    //command2.Parameters.Add("@CustomerNationalNumber", OleDbType.VarChar);
                    //command2.Parameters.Add("@CustomerOrg", OleDbType.VarChar);
                    //command2.Parameters.Add("@CustomerPhone", OleDbType.VarChar);
                    //command2.Parameters.Add("@CustomerAddress", OleDbType.VarChar);
                    //command2.Parameters.Add("@Id", OleDbType.Integer);



                    //command2.Parameters["@CustomerType"].Value = ctype;

                    //command2.Parameters["@CustomerName"].Value = CustomerNameTXT.Text;
                    //command2.Parameters["@CustomerNationalNumber"].Value = CustomerNationalNumberTXT.Text;
                    //command2.Parameters["@CustomerOrg"].Value = CustomerOrgTXT.Text;
                    //command2.Parameters["@CustomerPhone"].Value = CustomerPhoneTXT.Text;
                    //command2.Parameters["@CustomerAddress"].Value = CustomerAddressTXT.Text;
                    //command2.Parameters["@Id"].Value = customerId;

                    //con.Open();
                    //command2.ExecuteNonQuery();
                    //con.Close();

                    int ctype = 0;
                    if (Type)
                    {
                        ctype = 1;
                    }
                    con.Open();
                    cmd = new OleDbCommand("UPDATE tbl_Customers SET " +
                        " CustomerName = '" + CustomerNameTXT.Text + "'" +
                        ",CustomerNationalNumber='" + CustomerNationalNumberTXT.Text + "' " +
                        ",CustomerOrg='" + CustomerOrgTXT.Text + "'" +
                        ",CustomerPhone='" + CustomerPhoneTXT.Text + "'" +
                        ",CustomerAddress='" + CustomerAddressTXT.Text + "'" +
                        ",CustomerType =" + ctype +
                        " WHERE ID =" + customerId, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    fillGrid();
                    editBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                    newBtn.Enabled = true;
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
            if (customerId == 0)
            {

                MessageBox.Show("حصولی جهت حذف انتخاب نشده است", "خطا", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string cmdUpdate = @"UPDATE tbl_Customers   
                    set 
                        isActive =false
                    where ID = @Id";

                    OleDbCommand command2 = new OleDbCommand(cmdUpdate, con);
                    command2.Parameters.Add("@Id", OleDbType.Integer);
                    command2.Parameters["@Id"].Value = customerId;

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

        private void ClearForm()
        {
            CustomerNameTXT.Text = "";
            CustomerNationalNumberTXT.Text = "";
            CustomerOrgTXT.Text = "";
            CustomerPhoneTXT.Text = "";
            CustomerAddressTXT.Text = "";
            CustomerOrgTXT.Enabled = false;
            label2.Text = "کد ملی";
            Type = false;
            PersonRadio.Checked = true;
            OrgRadio.Checked = false;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            AddBtn.Enabled = true;

        }

        private void fillGrid()
        {
            con.Open();
            OleDbDataAdapter = new OleDbDataAdapter("SELECT ID, CustomerType, CustomerName, CustomerNationalNumber, CustomerOrg, CustomerPhone,CustomerAddress FROM  tbl_Customers WHERE  IsActive = true  ", con);
            con.Close();
            OleDbCommandBuilder ocb = new OleDbCommandBuilder(OleDbDataAdapter);
            dt = new DataTable();
            OleDbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private int checkValidation(bool customerType)
        {
            int errorCount = 0;

            if (string.IsNullOrEmpty(CustomerNameTXT.Text) || string.IsNullOrWhiteSpace(CustomerNameTXT.Text))
            {
                errorCount = errorCount + 1;
                MessageBox.Show("لطفا نام مشتری را وارد کنید", "خطا", MessageBoxButtons.OK);

            }
            else if (string.IsNullOrEmpty(CustomerNationalNumberTXT.Text) || string.IsNullOrWhiteSpace(CustomerNationalNumberTXT.Text))
            {
                if (customerType == true)
                {
                    errorCount = errorCount + 1;
                    MessageBox.Show("لطفا کد ملی سازمان را وارد کنید", "خطا", MessageBoxButtons.OK);
                }

            }
            else if (string.IsNullOrEmpty(CustomerNationalNumberTXT.Text) || string.IsNullOrWhiteSpace(CustomerNationalNumberTXT.Text))
            {
                if (customerType == false)
                {
                    errorCount = errorCount + 1;
                    MessageBox.Show("لطفا کد ملی شخص را وارد کنید", "خطا", MessageBoxButtons.OK);
                }
            }
            else if (string.IsNullOrEmpty(CustomerOrgTXT.Text) || string.IsNullOrWhiteSpace(CustomerOrgTXT.Text))
            {
                if (customerType == true)
                {
                    errorCount = errorCount + 1;
                    MessageBox.Show("لطفا نام سازمان را وارد کنید", "خطا", MessageBoxButtons.OK);
                }
            }
            else if (string.IsNullOrEmpty(CustomerPhoneTXT.Text) || string.IsNullOrWhiteSpace(CustomerPhoneTXT.Text))
            {
                errorCount = errorCount + 1;
                MessageBox.Show("لطفا تلفن تماس را وارد کنید", "خطا", MessageBoxButtons.OK);

            }
            return errorCount;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

   

        private void textEdit3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
            CustomerNameTXT.Text = row.Cells[2].Value.ToString();
            CustomerNationalNumberTXT.Text = row.Cells[3].Value.ToString();
            CustomerOrgTXT.Text = row.Cells[4].Value.ToString();
            CustomerPhoneTXT.Text = row.Cells[5].Value.ToString();
            CustomerAddressTXT.Text = row.Cells[6].Value.ToString();
            customerId = Convert.ToInt32(row.Cells[0].Value);
            bool ctype = Convert.ToBoolean(row.Cells[1].Value);
            if (ctype)
            {
                PersonRadio.Checked = false;
                OrgRadio.Checked = true;
                CustomerOrgTXT.Enabled = true;
                label2.Text = "شناسه ملی";

            }
            else if (!ctype)
            {
                PersonRadio.Checked = true;
                OrgRadio.Checked = false;
                CustomerOrgTXT.Enabled = false;
                label2.Text = "کد ملی";

            }
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            AddBtn.Enabled = false;
            newBtn.Enabled = true;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
