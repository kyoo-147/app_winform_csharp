namespace BaiTapGiuaKy_BuiMinhCuong
{
    partial class Ex6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex6));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClock = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDate = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTime = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.itemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRight = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemClock,
            this.itemFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(263, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemThoat});
            this.itemFile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(40, 20);
            this.itemFile.Text = "File";
            // 
            // itemThoat
            // 
            this.itemThoat.Name = "itemThoat";
            this.itemThoat.ShortcutKeyDisplayString = "Alt + X";
            this.itemThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.itemThoat.Size = new System.Drawing.Size(149, 22);
            this.itemThoat.Text = "Thoát";
            this.itemThoat.Click += new System.EventHandler(this.itemThoat_Click);
            // 
            // itemClock
            // 
            this.itemClock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDate,
            this.itemTime});
            this.itemClock.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemClock.Name = "itemClock";
            this.itemClock.Size = new System.Drawing.Size(50, 20);
            this.itemClock.Text = "Clock";
            // 
            // itemDate
            // 
            this.itemDate.Name = "itemDate";
            this.itemDate.Size = new System.Drawing.Size(102, 22);
            this.itemDate.Text = "Date";
            this.itemDate.Click += new System.EventHandler(this.itemDate_Click);
            // 
            // itemTime
            // 
            this.itemTime.Name = "itemTime";
            this.itemTime.Size = new System.Drawing.Size(102, 22);
            this.itemTime.Text = "Time";
            this.itemTime.Click += new System.EventHandler(this.itemTime_Click);
            // 
            // itemFormat
            // 
            this.itemFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFont,
            this.itemColor,
            this.itemAlign});
            this.itemFormat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFormat.Name = "itemFormat";
            this.itemFormat.Size = new System.Drawing.Size(57, 20);
            this.itemFormat.Text = "Format";
            // 
            // itemFont
            // 
            this.itemFont.Name = "itemFont";
            this.itemFont.Size = new System.Drawing.Size(104, 22);
            this.itemFont.Text = "Font";
            this.itemFont.Click += new System.EventHandler(this.itemFont_Click);
            // 
            // itemColor
            // 
            this.itemColor.Name = "itemColor";
            this.itemColor.Size = new System.Drawing.Size(104, 22);
            this.itemColor.Text = "Color";
            this.itemColor.Click += new System.EventHandler(this.itemColor_Click);
            // 
            // itemAlign
            // 
            this.itemAlign.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLeft,
            this.itemRight,
            this.itemCenter});
            this.itemAlign.Name = "itemAlign";
            this.itemAlign.Size = new System.Drawing.Size(104, 22);
            this.itemAlign.Text = "Align";
            // 
            // itemLeft
            // 
            this.itemLeft.Name = "itemLeft";
            this.itemLeft.Size = new System.Drawing.Size(111, 22);
            this.itemLeft.Text = "Left";
            this.itemLeft.Click += new System.EventHandler(this.itemLeft_Click);
            // 
            // itemRight
            // 
            this.itemRight.Name = "itemRight";
            this.itemRight.Size = new System.Drawing.Size(111, 22);
            this.itemRight.Text = "Right";
            this.itemRight.Click += new System.EventHandler(this.itemRight_Click);
            // 
            // itemCenter
            // 
            this.itemCenter.Name = "itemCenter";
            this.itemCenter.Size = new System.Drawing.Size(111, 22);
            this.itemCenter.Text = "Center";
            this.itemCenter.Click += new System.EventHandler(this.itemCenter_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(11, 26);
            this.txtBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(241, 253);
            this.txtBox.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // Ex6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(263, 290);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ex6";
            this.Text = "Cau5_Bai1";
            this.Load += new System.EventHandler(this.VD6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemThoat;
        private System.Windows.Forms.ToolStripMenuItem itemClock;
        private System.Windows.Forms.ToolStripMenuItem itemDate;
        private System.Windows.Forms.ToolStripMenuItem itemTime;
        private System.Windows.Forms.ToolStripMenuItem itemFormat;
        private System.Windows.Forms.ToolStripMenuItem itemFont;
        private System.Windows.Forms.ToolStripMenuItem itemColor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem itemAlign;
        private System.Windows.Forms.ToolStripMenuItem itemLeft;
        private System.Windows.Forms.ToolStripMenuItem itemRight;
        private System.Windows.Forms.ToolStripMenuItem itemCenter;
    }
}