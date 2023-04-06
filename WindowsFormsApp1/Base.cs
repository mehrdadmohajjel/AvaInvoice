using DevExpress.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Base : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Invoice.mdb");
        private OleDbCommand cmd;
        private OleDbDataAdapter OleDbDataAdapter;
        private DataTable dt;
        private int id = 0;
        private string fileName = "";
        private string destiniation = "";
        private string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        public Base()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton2.Enabled = true;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "انتخاب عکس",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                 "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(textBox1.Text);
                fileName = openFileDialog1.SafeFileName;
                destiniation = path + "/Logo/" + fileName;
                System.IO.File.Copy(textBox1.Text, destiniation);

            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var errcount = 0;

                if (string.IsNullOrEmpty(CompanyNameTXT.Text) || string.IsNullOrWhiteSpace(CompanyNameTXT.Text))
                {
                    errcount = errcount + 1;
                    MessageBox.Show("لطفا نام شرکت را وارد کنید", "خطا", MessageBoxButtons.OK);
                }
                if (string.IsNullOrEmpty(TellTXT.Text) || string.IsNullOrWhiteSpace(TellTXT.Text))
                {
                    errcount = errcount + 1;

                    MessageBox.Show("لطفا شماره تلفن را وارد کنید", "خطا", MessageBoxButtons.OK);
                }
                if (string.IsNullOrEmpty(AddressTXT.Text) || string.IsNullOrWhiteSpace(AddressTXT.Text))
                {
                    errcount = errcount + 1;

                    MessageBox.Show("لطفا آدرس را وارد کنید", "خطا", MessageBoxButtons.OK);
                }

                if (errcount == 0)
                {
                    try
                    {

                        con.Open();
                        cmd = new OleDbCommand("UPDATE tbl_BaseInfo SET " +
                            " CompanyName = '" + CompanyNameTXT.Text + "'" +
                            ",Code='" + CodeTXT.Text + "' " +
                            ",Tell='" + TellTXT.Text + "'" +
                            ",Address='" + AddressTXT.Text + "'" +
                            ",LogoUrl= '" + fileName + "'" +
                            " WHERE ID =" + id, con);
                        //var query = @"UPDATE tbl_BaseInfo SET " +
                        //    " CompanyName = '" + CompanyNameTXT.Text + "'" +
                        //    ",Code='" + CodeTXT.Text + "' " +
                        //    ",Tell='" + TellTXT.Text + "'" +
                        //    ",Address='" + AddressTXT.Text + "'" +
                        //    " WHERE ID =" + id;
                        //Tools.ExecuteSQLQuery(query);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        fillInfo();
                        MessageBox.Show("اطلاعات با موفقیت بروز شد", "ثبت اطلاعات", MessageBoxButtons.OK);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
            else
            {
                var errcount = 0;

                if (string.IsNullOrEmpty(CompanyNameTXT.Text) || string.IsNullOrWhiteSpace(CompanyNameTXT.Text))
                {
                    errcount = errcount + 1;
                    MessageBox.Show("لطفا نام شرکت را وارد کنید", "خطا", MessageBoxButtons.OK);
                }
                if (string.IsNullOrEmpty(TellTXT.Text) || string.IsNullOrWhiteSpace(TellTXT.Text))
                {
                    errcount = errcount + 1;

                    MessageBox.Show("لطفا شماره تلفن را وارد کنید", "خطا", MessageBoxButtons.OK);
                }
                if (string.IsNullOrEmpty(AddressTXT.Text) || string.IsNullOrWhiteSpace(AddressTXT.Text))
                {
                    errcount = errcount + 1;

                    MessageBox.Show("لطفا آدرس را وارد کنید", "خطا", MessageBoxButtons.OK);
                }

                if (errcount == 0)
                {
                    try
                    {
                        con.Open();
                        cmd = new OleDbCommand("INSERT INTO tbl_BaseInfo(CompanyName,Code,Tell,Address,LogoUrl) Values('" + CompanyNameTXT.Text + "','" + CodeTXT.Text + "' ,'" + TellTXT.Text + "','" + AddressTXT.Text + "' ,'" + fileName + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        fillInfo();
                        MessageBox.Show("اطلاعات با موفقیت ثبت شد", "ثبت اطلاعات", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
        }
        private void fillInfo()
        {
            con.Open();
            OleDbDataAdapter = new OleDbDataAdapter("Select TOP 1 ID,CompanyName,Code,Tell,Address,LogoUrl FROM tbl_BaseInfo  ", con);
            con.Close();
            OleDbCommandBuilder ocb = new OleDbCommandBuilder(OleDbDataAdapter);
            dt = new DataTable();
            OleDbDataAdapter.Fill(dt);

            //factorNumberLBL.Text = dt.;
            if (dt.Rows.Count != 0)
            {
                CompanyNameTXT.Text = dt.Rows[0].ItemArray[1].ToString();
                CodeTXT.Text = dt.Rows[0].ItemArray[2].ToString();
                TellTXT.Text = dt.Rows[0].ItemArray[3].ToString();
                AddressTXT.Text = dt.Rows[0].ItemArray[4].ToString();
                id = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                destiniation = path + "/Logo/" + dt.Rows[0].ItemArray[5].ToString();

                pictureBox1.Image = Image.FromFile(destiniation);

            }
            else
            {
                simpleButton2.Enabled = false;
            }
        }

        private void Base_Load(object sender, EventArgs e)
        {
            fillInfo();

        }

        private void CompanyNameTXT_Leave(object sender, EventArgs e)
        {
            simpleButton2.Enabled = true;
        }

        private void CodeTXT_Leave(object sender, EventArgs e)
        {
            simpleButton2.Enabled = true;
        }

        private void TellTXT_Leave(object sender, EventArgs e)
        {
            simpleButton2.Enabled = true;
        }

        private void AddressTXT_Leave(object sender, EventArgs e)
        {
            simpleButton2.Enabled = true;
        }
    }
}
