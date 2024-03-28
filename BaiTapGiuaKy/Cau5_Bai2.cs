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
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }
        private void VD7_Load(object sender, EventArgs e)
        { }
        private void itemWindow_Click(object sender, EventArgs e)
        { }
        // Hien thi Cau 1 - Bai 5
        private void itemBai1_Click(object sender, EventArgs e)
        {
            Cau5_Bai1 B5_Cau_1 = new Cau5_Bai1();
            B5_Cau_1.Show();
        }
        // Hien thi Cau 2 - Bai 5
        private void itemBai2_Click(object sender, EventArgs e)
        {
            Cau5_Bai2 B5_Cau_2 = new Cau5_Bai2();
            B5_Cau_2.Show();
        }
        // Hien thi Cau 3 - Bai 5
        private void itemBai3_Click(object sender, EventArgs e)
        {
            Cau5_Bai3 B5_Cau_3 = new Cau5_Bai3();
            B5_Cau_3.Show();
        }
        // Hien thi Cau 4 - Bai 5
        private void itemBai4_Click(object sender, EventArgs e)
        {
            Cau5_Bai4 B5_Cau_4 = new Cau5_Bai4();
            B5_Cau_4.Show();
        }
        // Exit chuong trinh
        private void itemThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
