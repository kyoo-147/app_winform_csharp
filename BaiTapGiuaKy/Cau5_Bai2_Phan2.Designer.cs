namespace BaiTapGiuaKy_BuiMinhCuong
{
    partial class Cau5_Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cau5_Bai2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clSoThich = new System.Windows.Forms.CheckedListBox();
            this.cboMau = new System.Windows.Forms.ComboBox();
            this.btnSoThichCuaBan = new System.Windows.Forms.Button();
            this.btnMauBanThich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sở thích của bạn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Màu bạn thích";
            // 
            // clSoThich
            // 
            this.clSoThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSoThich.FormattingEnabled = true;
            this.clSoThich.Items.AddRange(new object[] {
            "Nghe nhạc",
            "Xem phim",
            "Chơi thể thao ",
            "Đi mua sắm",
            "Đi du lịch"});
            this.clSoThich.Location = new System.Drawing.Point(28, 24);
            this.clSoThich.Margin = new System.Windows.Forms.Padding(2);
            this.clSoThich.Name = "clSoThich";
            this.clSoThich.Size = new System.Drawing.Size(152, 99);
            this.clSoThich.TabIndex = 2;
            this.clSoThich.SelectedIndexChanged += new System.EventHandler(this.clSoThich_SelectedIndexChanged);
            // 
            // cboMau
            // 
            this.cboMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMau.FormattingEnabled = true;
            this.cboMau.Items.AddRange(new object[] {
            "Đỏ",
            "Trắng",
            "Vàng",
            "Hồng",
            "Tím"});
            this.cboMau.Location = new System.Drawing.Point(184, 24);
            this.cboMau.Margin = new System.Windows.Forms.Padding(2);
            this.cboMau.Name = "cboMau";
            this.cboMau.Size = new System.Drawing.Size(135, 120);
            this.cboMau.TabIndex = 3;
            this.cboMau.SelectedIndexChanged += new System.EventHandler(this.cboMau_SelectedIndexChanged);
            // 
            // btnSoThichCuaBan
            // 
            this.btnSoThichCuaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoThichCuaBan.Location = new System.Drawing.Point(28, 148);
            this.btnSoThichCuaBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSoThichCuaBan.Name = "btnSoThichCuaBan";
            this.btnSoThichCuaBan.Size = new System.Drawing.Size(139, 36);
            this.btnSoThichCuaBan.TabIndex = 4;
            this.btnSoThichCuaBan.Text = "Sở thích của bạn";
            this.btnSoThichCuaBan.UseVisualStyleBackColor = true;
            this.btnSoThichCuaBan.Click += new System.EventHandler(this.btnSoThichCuaBan_Click);
            // 
            // btnMauBanThich
            // 
            this.btnMauBanThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMauBanThich.Location = new System.Drawing.Point(184, 148);
            this.btnMauBanThich.Margin = new System.Windows.Forms.Padding(2);
            this.btnMauBanThich.Name = "btnMauBanThich";
            this.btnMauBanThich.Size = new System.Drawing.Size(134, 36);
            this.btnMauBanThich.TabIndex = 5;
            this.btnMauBanThich.Text = "Màu bạn thích";
            this.btnMauBanThich.UseVisualStyleBackColor = true;
            this.btnMauBanThich.Click += new System.EventHandler(this.btnMauBanThich_Click);
            // 
            // Cau5_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(352, 192);
            this.Controls.Add(this.btnMauBanThich);
            this.Controls.Add(this.btnSoThichCuaBan);
            this.Controls.Add(this.cboMau);
            this.Controls.Add(this.clSoThich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cau5_Bai2";
            this.Text = "Cau5_Bai2_Phan2";
            this.Load += new System.EventHandler(this.BT2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clSoThich;
        private System.Windows.Forms.ComboBox cboMau;
        private System.Windows.Forms.Button btnSoThichCuaBan;
        private System.Windows.Forms.Button btnMauBanThich;
    }
}