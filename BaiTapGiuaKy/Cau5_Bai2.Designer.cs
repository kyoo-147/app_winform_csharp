namespace BaiTapGiuaKy_BuiMinhCuong
{
    partial class Ex7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex7));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBai4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBai1,
            this.itemBai2,
            this.itemBai3,
            this.itemBai4,
            this.toolStripSeparator1,
            this.itemThoat});
            this.itemFile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(40, 20);
            this.itemFile.Text = "File";
            // 
            // itemBai1
            // 
            this.itemBai1.Name = "itemBai1";
            this.itemBai1.Size = new System.Drawing.Size(105, 22);
            this.itemBai1.Text = "Bài 1";
            this.itemBai1.Click += new System.EventHandler(this.itemBai1_Click);
            // 
            // itemBai2
            // 
            this.itemBai2.Name = "itemBai2";
            this.itemBai2.Size = new System.Drawing.Size(105, 22);
            this.itemBai2.Text = "Bài 2";
            this.itemBai2.Click += new System.EventHandler(this.itemBai2_Click);
            // 
            // itemBai3
            // 
            this.itemBai3.Name = "itemBai3";
            this.itemBai3.Size = new System.Drawing.Size(105, 22);
            this.itemBai3.Text = "Bài 3";
            this.itemBai3.Click += new System.EventHandler(this.itemBai3_Click);
            // 
            // itemBai4
            // 
            this.itemBai4.Name = "itemBai4";
            this.itemBai4.Size = new System.Drawing.Size(105, 22);
            this.itemBai4.Text = "Bài 4";
            this.itemBai4.Click += new System.EventHandler(this.itemBai4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(102, 6);
            // 
            // itemThoat
            // 
            this.itemThoat.Name = "itemThoat";
            this.itemThoat.Size = new System.Drawing.Size(105, 22);
            this.itemThoat.Text = "Thoát";
            this.itemThoat.Click += new System.EventHandler(this.itemThoat_Click);
            // 
            // itemWindow
            // 
            this.itemWindow.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemWindow.Name = "itemWindow";
            this.itemWindow.Size = new System.Drawing.Size(61, 20);
            this.itemWindow.Text = "Window";
            this.itemWindow.Click += new System.EventHandler(this.itemWindow_Click);
            // 
            // Ex7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(370, 292);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ex7";
            this.Text = "Cau5_Bai2";
            this.Load += new System.EventHandler(this.VD7_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemBai1;
        private System.Windows.Forms.ToolStripMenuItem itemBai2;
        private System.Windows.Forms.ToolStripMenuItem itemBai3;
        private System.Windows.Forms.ToolStripMenuItem itemBai4;
        private System.Windows.Forms.ToolStripMenuItem itemWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemThoat;
    }
}