using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapGiuaKy_BuiMinhCuong
{
    //     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~     //
    //          Khoa: Công Nghệ Thông Tin                 //
    //          Lớp: 22CT115                              //
    //          MSSV: 122001458                           //
    //          STT: 06 - Số máy: 03                      //
    //          Tên: Bùi Minh Cường - Lớp Trưởng          //
    //          Môn: Lập trình trên môi trường windows    //
    //                                                    //
    ////////////////////////////////////////////////////////
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }
        
        // Dinh dang can le phai
        private void itemRight_Click(object sender, EventArgs e)
        {
            txtBox.TextAlign = HorizontalAlignment.Right;
        }
        // Dinh dang can le giua
        private void itemCenter_Click(object sender, EventArgs e)
        {
            txtBox.TextAlign = HorizontalAlignment.Center;
        }
        // Dinh dang can le trai
        private void itemLeft_Click(object sender, EventArgs e)
        {
            txtBox.TextAlign = HorizontalAlignment.Left;
        }
        private void VD6_Load(object sender, EventArgs e)
        { }
        // Hien thi muc ngay gio rut gon
        private void itemDate_Click(object sender, EventArgs e)
        {
            txtBox.Text = DateTime.Now.ToShortDateString();
        }
        // Hien thi muc ngay gio day du
        private void itemTime_Click(object sender, EventArgs e)
        {
            txtBox.Text = DateTime.Now.ToLongTimeString();
        }
        // Hien thi kieu chu
        private void Hien_Thi_Font_Chu()
        {
            FontDialog Hop_Kieu_Chu = new FontDialog();
            if (Hop_Kieu_Chu.ShowDialog() == DialogResult.OK)
            {
                txtBox.Font = Hop_Kieu_Chu.Font;
            }
        }
        private void itemFont_Click(object sender, EventArgs e)
        {
            Hien_Thi_Font_Chu();
        }

        // Hien thi mau sac
        private void Hien_Thi_Mau_Sac()
        {
            ColorDialog Hop_Mau_Sac = new ColorDialog();
            if (Hop_Mau_Sac.ShowDialog() == DialogResult.OK)
            {
                txtBox.ForeColor = Hop_Mau_Sac.Color;
            }
        }
        private void itemColor_Click(object sender, EventArgs e)
        {
            Hien_Thi_Mau_Sac();
        }
        // Exit chuong trinh
        private void itemThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
