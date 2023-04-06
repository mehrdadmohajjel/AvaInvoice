namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اطلاعاتپایهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتمحصولاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتمشتریانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتپایهسیستمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.صدورفاکتورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشاهدهفاکتورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دریافتوجهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشاهدهدریافتهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتپایهToolStripMenuItem,
            this.صدورفاکتورToolStripMenuItem,
            this.مشاهدهفاکتورToolStripMenuItem,
            this.دریافتوجهToolStripMenuItem,
            this.مشاهدهدریافتهاToolStripMenuItem,
            this.خروجToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // اطلاعاتپایهToolStripMenuItem
            // 
            this.اطلاعاتپایهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتمحصولاتToolStripMenuItem,
            this.مدیریتمشتریانToolStripMenuItem,
            this.اطلاعاتپایهسیستمToolStripMenuItem});
            this.اطلاعاتپایهToolStripMenuItem.Name = "اطلاعاتپایهToolStripMenuItem";
            this.اطلاعاتپایهToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.اطلاعاتپایهToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // مدیریتمحصولاتToolStripMenuItem
            // 
            this.مدیریتمحصولاتToolStripMenuItem.Name = "مدیریتمحصولاتToolStripMenuItem";
            this.مدیریتمحصولاتToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.مدیریتمحصولاتToolStripMenuItem.Text = "مدیریت محصولات";
            this.مدیریتمحصولاتToolStripMenuItem.Click += new System.EventHandler(this.مدیریتمحصولاتToolStripMenuItem_Click);
            // 
            // مدیریتمشتریانToolStripMenuItem
            // 
            this.مدیریتمشتریانToolStripMenuItem.Name = "مدیریتمشتریانToolStripMenuItem";
            this.مدیریتمشتریانToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.مدیریتمشتریانToolStripMenuItem.Text = "مدیریت مشتریان";
            this.مدیریتمشتریانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتمشتریانToolStripMenuItem_Click);
            // 
            // اطلاعاتپایهسیستمToolStripMenuItem
            // 
            this.اطلاعاتپایهسیستمToolStripMenuItem.Name = "اطلاعاتپایهسیستمToolStripMenuItem";
            this.اطلاعاتپایهسیستمToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.اطلاعاتپایهسیستمToolStripMenuItem.Text = "اطلاعات پایه سیستم";
            this.اطلاعاتپایهسیستمToolStripMenuItem.Click += new System.EventHandler(this.اطلاعاتپایهسیستمToolStripMenuItem_Click);
            // 
            // صدورفاکتورToolStripMenuItem
            // 
            this.صدورفاکتورToolStripMenuItem.Name = "صدورفاکتورToolStripMenuItem";
            this.صدورفاکتورToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.صدورفاکتورToolStripMenuItem.Text = "صدور فاکتور";
            this.صدورفاکتورToolStripMenuItem.Click += new System.EventHandler(this.صدورفاکتورToolStripMenuItem_Click);
            // 
            // مشاهدهفاکتورToolStripMenuItem
            // 
            this.مشاهدهفاکتورToolStripMenuItem.Name = "مشاهدهفاکتورToolStripMenuItem";
            this.مشاهدهفاکتورToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.مشاهدهفاکتورToolStripMenuItem.Text = "مشاهده فاکتور";
            this.مشاهدهفاکتورToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهفاکتورToolStripMenuItem_Click);
            // 
            // دریافتوجهToolStripMenuItem
            // 
            this.دریافتوجهToolStripMenuItem.Name = "دریافتوجهToolStripMenuItem";
            this.دریافتوجهToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.دریافتوجهToolStripMenuItem.Text = "دریافت وجه";
            this.دریافتوجهToolStripMenuItem.Click += new System.EventHandler(this.دریافتوجهToolStripMenuItem_Click);
            // 
            // مشاهدهدریافتهاToolStripMenuItem
            // 
            this.مشاهدهدریافتهاToolStripMenuItem.Name = "مشاهدهدریافتهاToolStripMenuItem";
            this.مشاهدهدریافتهاToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.مشاهدهدریافتهاToolStripMenuItem.Text = "مشاهده دریافت ها";
            this.مشاهدهدریافتهاToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهدریافتهاToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem1
            // 
            this.خروجToolStripMenuItem1.Name = "خروجToolStripMenuItem1";
            this.خروجToolStripMenuItem1.Size = new System.Drawing.Size(49, 22);
            this.خروجToolStripMenuItem1.Text = "خروج";
            this.خروجToolStripMenuItem1.Click += new System.EventHandler(this.خروجToolStripMenuItem1_Click);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت فاکتور";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتمحصولاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتمشتریانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهسیستمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem صدورفاکتورToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهفاکتورToolStripMenuItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem دریافتوجهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهدریافتهاToolStripMenuItem;
    }
}

