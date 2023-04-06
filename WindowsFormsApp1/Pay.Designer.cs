namespace WindowsFormsApp1
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerCombo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerOrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FactorLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BillNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BillAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SendPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FinalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DiscountLBL = new System.Windows.Forms.Label();
            this.SendPriceLBL = new System.Windows.Forms.Label();
            this.FactorDateLBL = new System.Windows.Forms.Label();
            this.FactorPriceLBL = new System.Windows.Forms.Label();
            this.FactorNumberLBL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FinalPriceLBL = new System.Windows.Forms.Label();
            this.PayRadio = new System.Windows.Forms.RadioButton();
            this.CheckPayRadio = new System.Windows.Forms.RadioButton();
            this.PayPriceLBL = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.persianDatePicker1 = new System.Windows.Forms.PersianDatePicker();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.CheckPriceTXT = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.CheckNumberTXT = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdate = new DevExpress.XtraEditors.TextEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactorLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayPriceLBL.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPriceTXT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckNumberTXT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerCombo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FactorLookUp, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 90);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(377, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "فاکتور";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(375, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "مشتری";
            // 
            // CustomerCombo
            // 
            this.CustomerCombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerCombo.EditValue = "انتخاب مشتری";
            this.CustomerCombo.Location = new System.Drawing.Point(3, 8);
            this.CustomerCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerCombo.Name = "CustomerCombo";
            this.CustomerCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerCombo.Properties.PopupView = this.searchLookUpEdit2View;
            this.CustomerCombo.Size = new System.Drawing.Size(356, 20);
            this.CustomerCombo.TabIndex = 9;
            this.CustomerCombo.EditValueChanged += new System.EventHandler(this.CustomerCombo_EditValueChanged);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CustomerName,
            this.CustomerOrg});
            this.searchLookUpEdit2View.DetailHeight = 458;
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // CustomerName
            // 
            this.CustomerName.Caption = "نام مشتری";
            this.CustomerName.FieldName = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Visible = true;
            this.CustomerName.VisibleIndex = 0;
            // 
            // CustomerOrg
            // 
            this.CustomerOrg.Caption = "سازمان";
            this.CustomerOrg.FieldName = "CustomerOrg";
            this.CustomerOrg.Name = "CustomerOrg";
            this.CustomerOrg.Visible = true;
            this.CustomerOrg.VisibleIndex = 1;
            // 
            // FactorLookUp
            // 
            this.FactorLookUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FactorLookUp.EditValue = "انتخاب فاکتور مشتری";
            this.FactorLookUp.Location = new System.Drawing.Point(3, 53);
            this.FactorLookUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FactorLookUp.Name = "FactorLookUp";
            this.FactorLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FactorLookUp.Properties.PopupView = this.gridView1;
            this.FactorLookUp.Size = new System.Drawing.Size(356, 20);
            this.FactorLookUp.TabIndex = 10;
            this.FactorLookUp.EditValueChanged += new System.EventHandler(this.FactorLookUp_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BillNumber,
            this.BillDate,
            this.BillAmount,
            this.Discount,
            this.SendPrice,
            this.FinalPrice});
            this.gridView1.DetailHeight = 458;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BillNumber
            // 
            this.BillNumber.Caption = "شماره فاکتور";
            this.BillNumber.FieldName = "BillNumber";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.Visible = true;
            this.BillNumber.VisibleIndex = 0;
            // 
            // BillDate
            // 
            this.BillDate.Caption = "تاریخ سفارش";
            this.BillDate.FieldName = "BillDate";
            this.BillDate.Name = "BillDate";
            this.BillDate.Visible = true;
            this.BillDate.VisibleIndex = 1;
            // 
            // BillAmount
            // 
            this.BillAmount.Caption = "مبلغ فاکتور";
            this.BillAmount.FieldName = "BillAmount";
            this.BillAmount.Name = "BillAmount";
            this.BillAmount.Visible = true;
            this.BillAmount.VisibleIndex = 2;
            // 
            // Discount
            // 
            this.Discount.Caption = "تخفیف";
            this.Discount.FieldName = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Visible = true;
            this.Discount.VisibleIndex = 3;
            // 
            // SendPrice
            // 
            this.SendPrice.Caption = "هزینه ارسال";
            this.SendPrice.FieldName = "SendPrice";
            this.SendPrice.Name = "SendPrice";
            this.SendPrice.Visible = true;
            this.SendPrice.VisibleIndex = 4;
            // 
            // FinalPrice
            // 
            this.FinalPrice.Caption = "مبلغ کل";
            this.FinalPrice.FieldName = "FinalPrice";
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.Visible = true;
            this.FinalPrice.VisibleIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.44186F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.13953F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.41861F));
            this.tableLayoutPanel2.Controls.Add(this.DiscountLBL, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.SendPriceLBL, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.FactorDateLBL, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.FactorPriceLBL, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.FactorNumberLBL, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.FinalPriceLBL, 3, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(431, 91);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DiscountLBL
            // 
            this.DiscountLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiscountLBL.AutoSize = true;
            this.DiscountLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DiscountLBL.ForeColor = System.Drawing.Color.Red;
            this.DiscountLBL.Location = new System.Drawing.Point(282, 65);
            this.DiscountLBL.Name = "DiscountLBL";
            this.DiscountLBL.Size = new System.Drawing.Size(19, 20);
            this.DiscountLBL.TabIndex = 16;
            this.DiscountLBL.Text = "0";
            // 
            // SendPriceLBL
            // 
            this.SendPriceLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SendPriceLBL.AutoSize = true;
            this.SendPriceLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SendPriceLBL.ForeColor = System.Drawing.Color.Red;
            this.SendPriceLBL.Location = new System.Drawing.Point(65, 35);
            this.SendPriceLBL.Name = "SendPriceLBL";
            this.SendPriceLBL.Size = new System.Drawing.Size(19, 20);
            this.SendPriceLBL.TabIndex = 16;
            this.SendPriceLBL.Text = "0";
            // 
            // FactorDateLBL
            // 
            this.FactorDateLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FactorDateLBL.AutoSize = true;
            this.FactorDateLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FactorDateLBL.ForeColor = System.Drawing.Color.Red;
            this.FactorDateLBL.Location = new System.Drawing.Point(65, 5);
            this.FactorDateLBL.Name = "FactorDateLBL";
            this.FactorDateLBL.Size = new System.Drawing.Size(19, 20);
            this.FactorDateLBL.TabIndex = 16;
            this.FactorDateLBL.Text = "0";
            // 
            // FactorPriceLBL
            // 
            this.FactorPriceLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FactorPriceLBL.AutoSize = true;
            this.FactorPriceLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FactorPriceLBL.ForeColor = System.Drawing.Color.Red;
            this.FactorPriceLBL.Location = new System.Drawing.Point(282, 35);
            this.FactorPriceLBL.Name = "FactorPriceLBL";
            this.FactorPriceLBL.Size = new System.Drawing.Size(19, 20);
            this.FactorPriceLBL.TabIndex = 16;
            this.FactorPriceLBL.Text = "0";
            // 
            // FactorNumberLBL
            // 
            this.FactorNumberLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FactorNumberLBL.AutoSize = true;
            this.FactorNumberLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FactorNumberLBL.ForeColor = System.Drawing.Color.Red;
            this.FactorNumberLBL.Location = new System.Drawing.Point(282, 5);
            this.FactorNumberLBL.Name = "FactorNumberLBL";
            this.FactorNumberLBL.Size = new System.Drawing.Size(19, 20);
            this.FactorNumberLBL.TabIndex = 16;
            this.FactorNumberLBL.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(388, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "تخفیف";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(365, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "مبلغ فاکتور";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(389, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "فاکتور";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(189, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "تاریخ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(152, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "هزینه ارسال";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(165, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "مبلغ نهایی";
            // 
            // FinalPriceLBL
            // 
            this.FinalPriceLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinalPriceLBL.AutoSize = true;
            this.FinalPriceLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FinalPriceLBL.ForeColor = System.Drawing.Color.Red;
            this.FinalPriceLBL.Location = new System.Drawing.Point(65, 65);
            this.FinalPriceLBL.Name = "FinalPriceLBL";
            this.FinalPriceLBL.Size = new System.Drawing.Size(19, 20);
            this.FinalPriceLBL.TabIndex = 16;
            this.FinalPriceLBL.Text = "0";
            // 
            // PayRadio
            // 
            this.PayRadio.AutoSize = true;
            this.PayRadio.Checked = true;
            this.PayRadio.Location = new System.Drawing.Point(351, 215);
            this.PayRadio.Name = "PayRadio";
            this.PayRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PayRadio.Size = new System.Drawing.Size(92, 22);
            this.PayRadio.TabIndex = 2;
            this.PayRadio.TabStop = true;
            this.PayRadio.Text = "پرداخت نقدی";
            this.PayRadio.UseVisualStyleBackColor = true;
            this.PayRadio.CheckedChanged += new System.EventHandler(this.PayRadio_CheckedChanged);
            // 
            // CheckPayRadio
            // 
            this.CheckPayRadio.AutoSize = true;
            this.CheckPayRadio.Location = new System.Drawing.Point(228, 215);
            this.CheckPayRadio.Name = "CheckPayRadio";
            this.CheckPayRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckPayRadio.Size = new System.Drawing.Size(110, 22);
            this.CheckPayRadio.TabIndex = 3;
            this.CheckPayRadio.TabStop = true;
            this.CheckPayRadio.Text = "پرداخت اعتباری";
            this.CheckPayRadio.UseVisualStyleBackColor = true;
            this.CheckPayRadio.CheckedChanged += new System.EventHandler(this.CheckPayRadio_CheckedChanged);
            // 
            // PayPriceLBL
            // 
            this.PayPriceLBL.Location = new System.Drawing.Point(175, 17);
            this.PayPriceLBL.Name = "PayPriceLBL";
            this.PayPriceLBL.Size = new System.Drawing.Size(189, 20);
            this.PayPriceLBL.TabIndex = 4;
            this.PayPriceLBL.TextChanged += new System.EventHandler(this.PayPriceLBL_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(370, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "مبلغ پرداختی";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.PayPriceLBL);
            this.panel1.Location = new System.Drawing.Point(2, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 60);
            this.panel1.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(71, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(137, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 18);
            this.label13.TabIndex = 14;
            this.label13.Text = "مانده";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.persianDatePicker1);
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.CheckPriceTXT);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.CheckNumberTXT);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtUpdate);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(2, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 287);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // persianDatePicker1
            // 
            this.persianDatePicker1.AutoSize = true;
            this.persianDatePicker1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.persianDatePicker1.BackColor = System.Drawing.Color.White;
            this.persianDatePicker1.GeorgianDate = null;
            this.persianDatePicker1.Location = new System.Drawing.Point(10, 5);
            this.persianDatePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.persianDatePicker1.Name = "persianDatePicker1";
            this.persianDatePicker1.PersianDate.Day = 0;
            this.persianDatePicker1.PersianDate.Month = 0;
            this.persianDatePicker1.PersianDate.Year = 0;
            this.persianDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persianDatePicker1.Size = new System.Drawing.Size(372, 28);
            this.persianDatePicker1.TabIndex = 34;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton3.Enabled = false;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(21, 57);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(36, 28);
            this.simpleButton3.TabIndex = 33;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(63, 54);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(41, 33);
            this.simpleButton2.TabIndex = 32;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // CheckPriceTXT
            // 
            this.CheckPriceTXT.Location = new System.Drawing.Point(110, 69);
            this.CheckPriceTXT.Name = "CheckPriceTXT";
            this.CheckPriceTXT.Size = new System.Drawing.Size(265, 20);
            this.CheckPriceTXT.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(385, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "مبلغ چک";
            // 
            // CheckNumberTXT
            // 
            this.CheckNumberTXT.Location = new System.Drawing.Point(110, 42);
            this.CheckNumberTXT.Name = "CheckNumberTXT";
            this.CheckNumberTXT.Size = new System.Drawing.Size(265, 20);
            this.CheckNumberTXT.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(377, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "شماره چک";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(383, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "تاریخ چک";
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(167, 287);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtUpdate.TabIndex = 19;
            this.txtUpdate.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.CheckPrice,
            this.CheckNumber,
            this.CheckDate});
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(449, 185);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 101.5228F;
            this.dataGridViewTextBoxColumn6.HeaderText = "ردیف";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // CheckPrice
            // 
            this.CheckPrice.FillWeight = 99.49239F;
            this.CheckPrice.HeaderText = "مبلغ چک";
            this.CheckPrice.Name = "CheckPrice";
            this.CheckPrice.ReadOnly = true;
            // 
            // CheckNumber
            // 
            this.CheckNumber.FillWeight = 99.49239F;
            this.CheckNumber.HeaderText = "شماره چک";
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.ReadOnly = true;
            // 
            // CheckDate
            // 
            this.CheckDate.FillWeight = 99.49239F;
            this.CheckDate.HeaderText = "تاریخ چک";
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.ReadOnly = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(2, 626);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 45);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "ثبت";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 683);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CheckPayRadio);
            this.Controls.Add(this.PayRadio);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactorLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayPriceLBL.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPriceTXT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckNumberTXT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SearchLookUpEdit CustomerCombo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerOrg;
        private DevExpress.XtraEditors.SearchLookUpEdit FactorLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BillNumber;
        private DevExpress.XtraGrid.Columns.GridColumn BillDate;
        private DevExpress.XtraGrid.Columns.GridColumn BillAmount;
        private DevExpress.XtraGrid.Columns.GridColumn Discount;
        private DevExpress.XtraGrid.Columns.GridColumn SendPrice;
        private DevExpress.XtraGrid.Columns.GridColumn FinalPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DiscountLBL;
        private System.Windows.Forms.Label SendPriceLBL;
        private System.Windows.Forms.Label FactorDateLBL;
        private System.Windows.Forms.Label FactorPriceLBL;
        private System.Windows.Forms.Label FactorNumberLBL;
        private System.Windows.Forms.Label FinalPriceLBL;
        private System.Windows.Forms.RadioButton PayRadio;
        private System.Windows.Forms.RadioButton CheckPayRadio;
        private DevExpress.XtraEditors.TextEdit PayPriceLBL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit CheckPriceTXT;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit CheckNumberTXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckDate;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.PersianDatePicker persianDatePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}