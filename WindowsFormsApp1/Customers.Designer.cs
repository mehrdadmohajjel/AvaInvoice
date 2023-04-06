namespace WindowsFormsApp1
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.editBtn = new DevExpress.XtraEditors.SimpleButton();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CustomerAddressTXT = new System.Windows.Forms.RichTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.CustomerPhoneTXT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CustomerOrgTXT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.CustomerNationalNumberTXT = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.CustomerNameTXT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.OrgRadio = new System.Windows.Forms.RadioButton();
            this.PersonRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNationalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.searchTXT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhoneTXT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrgTXT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNationalNumberTXT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTXT.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTXT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.CustomerAddressTXT);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.CustomerPhoneTXT);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.CustomerOrgTXT);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.CustomerNationalNumberTXT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CustomerNameTXT);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.OrgRadio);
            this.groupBox1.Controls.Add(this.PersonRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(549, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت مشتریان";
            // 
            // newBtn
            // 
            this.newBtn.Appearance.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.newBtn.Appearance.Options.UseFont = true;
            this.newBtn.Enabled = false;
            this.newBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.ImageOptions.Image")));
            this.newBtn.Location = new System.Drawing.Point(308, 196);
            this.newBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(93, 44);
            this.newBtn.TabIndex = 15;
            this.newBtn.Text = "جدید";
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Appearance.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteBtn.Appearance.Options.UseFont = true;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(11, 196);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(93, 44);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Appearance.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editBtn.Appearance.Options.UseFont = true;
            this.editBtn.Enabled = false;
            this.editBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.ImageOptions.Image")));
            this.editBtn.Location = new System.Drawing.Point(110, 196);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(93, 44);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "ویرایش";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Appearance.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddBtn.Appearance.Options.UseFont = true;
            this.AddBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.ImageOptions.Image")));
            this.AddBtn.Location = new System.Drawing.Point(209, 196);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(93, 44);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "ذخیره";
            this.AddBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // CustomerAddressTXT
            // 
            this.CustomerAddressTXT.Location = new System.Drawing.Point(6, 124);
            this.CustomerAddressTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerAddressTXT.Name = "CustomerAddressTXT";
            this.CustomerAddressTXT.Size = new System.Drawing.Size(441, 69);
            this.CustomerAddressTXT.TabIndex = 11;
            this.CustomerAddressTXT.Text = "";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(498, 128);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 17);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "آدرس";
            // 
            // CustomerPhoneTXT
            // 
            this.CustomerPhoneTXT.Location = new System.Drawing.Point(6, 84);
            this.CustomerPhoneTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerPhoneTXT.Name = "CustomerPhoneTXT";
            this.CustomerPhoneTXT.Size = new System.Drawing.Size(157, 20);
            this.CustomerPhoneTXT.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(184, 90);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 17);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "تلفن تماس";
            // 
            // CustomerOrgTXT
            // 
            this.CustomerOrgTXT.Location = new System.Drawing.Point(267, 84);
            this.CustomerOrgTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerOrgTXT.Name = "CustomerOrgTXT";
            this.CustomerOrgTXT.Size = new System.Drawing.Size(181, 20);
            this.CustomerOrgTXT.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(481, 90);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 17);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "نام سازمان";
            // 
            // CustomerNationalNumberTXT
            // 
            this.CustomerNationalNumberTXT.Location = new System.Drawing.Point(6, 48);
            this.CustomerNationalNumberTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerNationalNumberTXT.Name = "CustomerNationalNumberTXT";
            this.CustomerNationalNumberTXT.Size = new System.Drawing.Size(157, 20);
            this.CustomerNationalNumberTXT.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(199, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "کد ملی";
            // 
            // CustomerNameTXT
            // 
            this.CustomerNameTXT.Location = new System.Drawing.Point(267, 48);
            this.CustomerNameTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerNameTXT.Name = "CustomerNameTXT";
            this.CustomerNameTXT.Size = new System.Drawing.Size(181, 20);
            this.CustomerNameTXT.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(455, 53);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "نام و نام خانوادگی";
            // 
            // OrgRadio
            // 
            this.OrgRadio.AutoSize = true;
            this.OrgRadio.Location = new System.Drawing.Point(339, 11);
            this.OrgRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrgRadio.Name = "OrgRadio";
            this.OrgRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrgRadio.Size = new System.Drawing.Size(76, 21);
            this.OrgRadio.TabIndex = 1;
            this.OrgRadio.Text = "شخص حقوقی";
            this.OrgRadio.UseVisualStyleBackColor = true;
            this.OrgRadio.CheckedChanged += new System.EventHandler(this.OrgRadio_CheckedChanged);
            // 
            // PersonRadio
            // 
            this.PersonRadio.AutoSize = true;
            this.PersonRadio.Checked = true;
            this.PersonRadio.Location = new System.Drawing.Point(438, 11);
            this.PersonRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonRadio.Name = "PersonRadio";
            this.PersonRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PersonRadio.Size = new System.Drawing.Size(76, 21);
            this.PersonRadio.TabIndex = 0;
            this.PersonRadio.TabStop = true;
            this.PersonRadio.Text = "شخص حقیقی";
            this.PersonRadio.UseVisualStyleBackColor = true;
            this.PersonRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.searchTXT);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Location = new System.Drawing.Point(2, 257);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(559, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست مشتریان";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerType,
            this.CustomerName,
            this.CustomerNationalNumber,
            this.CustomerOrg,
            this.CustomerPhone,
            this.CustomerAddress});
            this.dataGridView1.Location = new System.Drawing.Point(6, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(547, 222);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CustomerType
            // 
            this.CustomerType.DataPropertyName = "CustomerType";
            this.CustomerType.HeaderText = "نوع مشتری";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.ReadOnly = true;
            this.CustomerType.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.FillWeight = 200F;
            this.CustomerName.HeaderText = "نام و نام خانوادگی";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerNationalNumber
            // 
            this.CustomerNationalNumber.DataPropertyName = "CustomerNationalNumber";
            this.CustomerNationalNumber.HeaderText = "شناسه ملی";
            this.CustomerNationalNumber.Name = "CustomerNationalNumber";
            this.CustomerNationalNumber.ReadOnly = true;
            // 
            // CustomerOrg
            // 
            this.CustomerOrg.DataPropertyName = "CustomerOrg";
            this.CustomerOrg.HeaderText = "نام سازمان";
            this.CustomerOrg.Name = "CustomerOrg";
            this.CustomerOrg.ReadOnly = true;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.DataPropertyName = "CustomerPhone";
            this.CustomerPhone.HeaderText = "تلفن تماس";
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.ReadOnly = true;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "CustomerAddress";
            this.CustomerAddress.FillWeight = 250F;
            this.CustomerAddress.HeaderText = "آدرس";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.ReadOnly = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(42, 21);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(65, 21);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "بگرد";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // searchTXT
            // 
            this.searchTXT.Location = new System.Drawing.Point(120, 22);
            this.searchTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTXT.Name = "searchTXT";
            this.searchTXT.Size = new System.Drawing.Size(365, 20);
            this.searchTXT.TabIndex = 16;
            this.searchTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit3_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(491, 26);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "جستجوی";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customers";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت مشتریان";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhoneTXT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrgTXT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNationalNumberTXT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTXT.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTXT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit CustomerNameTXT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton OrgRadio;
        private System.Windows.Forms.RadioButton PersonRadio;
        private DevExpress.XtraEditors.TextEdit CustomerOrgTXT;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit CustomerNationalNumberTXT;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit CustomerPhoneTXT;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.RichTextBox CustomerAddressTXT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.SimpleButton editBtn;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit searchTXT;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton newBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNationalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
    }
}