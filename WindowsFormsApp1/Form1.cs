using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void اطلاعاتپایهسیستمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Base frm = new Base();
            frm.MdiParent = this;
            frm.Show();

        }

        private void مدیریتمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers frm = new Customers();
            frm.MdiParent = this;
            frm.Show();

        }

        private void مدیریتمحصولاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products frm = new Products();
            frm.MdiParent = this;
            frm.Show();
        }



        private void مشاهدهفاکتورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBills frm = new ViewBills();
            frm.MdiParent = this;
            frm.Show();

        }

        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void صدورفاکتورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBill frm = new NewBill();
            frm.MdiParent = this;
            frm.Show();
        }

        private void دریافتوجهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pay frm = new Pay();
            frm.MdiParent = this;
            frm.Show();
        }

        private void مشاهدهدریافتهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRecivedMoney frm = new ViewRecivedMoney();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
