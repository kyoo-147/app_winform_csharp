using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
    public partial class Cau5_Bai3 : Form
    {
        public Cau5_Bai3()
        {
            InitializeComponent();
        }
        // func khoi tao cac bien va dinh nghia no
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // dinh nghia cac bien
            DateTime Chon_Ngay = dateTimePicker1.Value;

            txtNow.Text = Chon_Ngay.ToShortDateString();
            txtDay.Text = Chon_Ngay.Day.ToString();
            txtMonth.Text = Chon_Ngay.Month.ToString();
            txtYear.Text = Chon_Ngay.Year.ToString();

            txtWeekday.Text = ((int)Chon_Ngay.DayOfWeek).ToString();
            txtDayOfYear.Text = Chon_Ngay.DayOfYear.ToString();
        }
        // Mo link 2
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Xu ly bat dau mo ung dung tinh toan
            Process.Start("calc.exe");
        }
        // Mo link 1
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Xu ly bat dau link LHU
            Process.Start("http://www.lhu.edu.vn");
        }
        private void BT3_Load(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
