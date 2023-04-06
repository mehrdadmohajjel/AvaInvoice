namespace WindowsFormsApp1
{
    partial class ViewBills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBills));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.persianDatePicker1 = new System.Windows.Forms.PersianDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.persianDatePicker2 = new System.Windows.Forms.PersianDatePicker();
            this.newBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalBillAmountLBL = new DevExpress.XtraEditors.LabelControl();
            this.TotalSendPriceLBL = new DevExpress.XtraEditors.LabelControl();
            this.TotalDisountLBL = new DevExpress.XtraEditors.LabelControl();
            this.TotalFinalPriceLBL = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.90047F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.71564F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.40284F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.08057F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.843602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.09479F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.606635F));
            this.tableLayoutPanel1.Controls.Add(this.simpleButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.persianDatePicker1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.persianDatePicker2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.newBtn, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 36);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(95, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(76, 30);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "حذف";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 30);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "چاپ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // persianDatePicker1
            // 
            this.persianDatePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.persianDatePicker1.AutoSize = true;
            this.persianDatePicker1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.persianDatePicker1.BackColor = System.Drawing.Color.White;
            this.persianDatePicker1.GeorgianDate = null;
            this.persianDatePicker1.Location = new System.Drawing.Point(571, 7);
            this.persianDatePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.persianDatePicker1.Name = "persianDatePicker1";
            this.persianDatePicker1.PersianDate.Day = 0;
            this.persianDatePicker1.PersianDate.Month = 0;
            this.persianDatePicker1.PersianDate.Year = 0;
            this.persianDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persianDatePicker1.Size = new System.Drawing.Size(248, 21);
            this.persianDatePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(824, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "از";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(545, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "تا";
            // 
            // persianDatePicker2
            // 
            this.persianDatePicker2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.persianDatePicker2.AutoSize = true;
            this.persianDatePicker2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.persianDatePicker2.BackColor = System.Drawing.Color.White;
            this.persianDatePicker2.GeorgianDate = null;
            this.persianDatePicker2.Location = new System.Drawing.Point(304, 7);
            this.persianDatePicker2.Margin = new System.Windows.Forms.Padding(0);
            this.persianDatePicker2.Name = "persianDatePicker2";
            this.persianDatePicker2.PersianDate.Day = 0;
            this.persianDatePicker2.PersianDate.Month = 0;
            this.persianDatePicker2.PersianDate.Year = 0;
            this.persianDatePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persianDatePicker2.Size = new System.Drawing.Size(237, 21);
            this.persianDatePicker2.TabIndex = 3;
            // 
            // newBtn
            // 
            this.newBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.newBtn.Appearance.Options.UseFont = true;
            this.newBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.ImageOptions.Image")));
            this.newBtn.Location = new System.Drawing.Point(177, 3);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(124, 30);
            this.newBtn.TabIndex = 20;
            this.newBtn.Text = "مشاهده فاکتورها";
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillNumber,
            this.BillAmount,
            this.SendPrice,
            this.Discount,
            this.FinalPrice,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(4, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(841, 396);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // BillNumber
            // 
            this.BillNumber.DataPropertyName = "BillNumber";
            this.BillNumber.HeaderText = "شماره فاکتور";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.ReadOnly = true;
            // 
            // BillAmount
            // 
            this.BillAmount.DataPropertyName = "BillAmount";
            this.BillAmount.HeaderText = "مبلغ فاکتور";
            this.BillAmount.Name = "BillAmount";
            this.BillAmount.ReadOnly = true;
            // 
            // SendPrice
            // 
            this.SendPrice.DataPropertyName = "SendPrice";
            this.SendPrice.HeaderText = "هزینه ارسال";
            this.SendPrice.Name = "SendPrice";
            this.SendPrice.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "تخخفیف";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // FinalPrice
            // 
            this.FinalPrice.DataPropertyName = "FinalPrice";
            this.FinalPrice.HeaderText = "مبلغ نهایی";
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel2.Controls.Add(this.TotalBillAmountLBL, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalSendPriceLBL, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalDisountLBL, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalFinalPriceLBL, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 441);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(841, 32);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // TotalBillAmountLBL
            // 
            this.TotalBillAmountLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalBillAmountLBL.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalBillAmountLBL.Appearance.Options.UseFont = true;
            this.TotalBillAmountLBL.Location = new System.Drawing.Point(550, 6);
            this.TotalBillAmountLBL.Name = "TotalBillAmountLBL";
            this.TotalBillAmountLBL.Size = new System.Drawing.Size(9, 20);
            this.TotalBillAmountLBL.TabIndex = 4;
            this.TotalBillAmountLBL.Text = "0";
            // 
            // TotalSendPriceLBL
            // 
            this.TotalSendPriceLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalSendPriceLBL.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalSendPriceLBL.Appearance.Options.UseFont = true;
            this.TotalSendPriceLBL.Location = new System.Drawing.Point(390, 6);
            this.TotalSendPriceLBL.Name = "TotalSendPriceLBL";
            this.TotalSendPriceLBL.Size = new System.Drawing.Size(9, 20);
            this.TotalSendPriceLBL.TabIndex = 3;
            this.TotalSendPriceLBL.Text = "0";
            // 
            // TotalDisountLBL
            // 
            this.TotalDisountLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalDisountLBL.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalDisountLBL.Appearance.Options.UseFont = true;
            this.TotalDisountLBL.Location = new System.Drawing.Point(229, 6);
            this.TotalDisountLBL.Name = "TotalDisountLBL";
            this.TotalDisountLBL.Size = new System.Drawing.Size(9, 20);
            this.TotalDisountLBL.TabIndex = 2;
            this.TotalDisountLBL.Text = "0";
            // 
            // TotalFinalPriceLBL
            // 
            this.TotalFinalPriceLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalFinalPriceLBL.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalFinalPriceLBL.Appearance.Options.UseFont = true;
            this.TotalFinalPriceLBL.Location = new System.Drawing.Point(72, 6);
            this.TotalFinalPriceLBL.Name = "TotalFinalPriceLBL";
            this.TotalFinalPriceLBL.Size = new System.Drawing.Size(9, 20);
            this.TotalFinalPriceLBL.TabIndex = 1;
            this.TotalFinalPriceLBL.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(699, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "مجموع گزارش";
            // 
            // ViewBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 492);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشاهده فاکتورهای صادرشده";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PersianDatePicker persianDatePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PersianDatePicker persianDatePicker2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton newBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl TotalBillAmountLBL;
        private DevExpress.XtraEditors.LabelControl TotalSendPriceLBL;
        private DevExpress.XtraEditors.LabelControl TotalDisountLBL;
        private DevExpress.XtraEditors.LabelControl TotalFinalPriceLBL;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}