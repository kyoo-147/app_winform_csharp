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
    public partial class Main : Form
    {
        // Ham Menu chinh de chuong trinh goi
        public Main()
        {
            InitializeComponent();
        }
        // Chuc nang 4 - Cau 1
        private void btnVD1_Click(object sender, EventArgs e)
        {
            Ex1 ChucNang4_1 = new Ex1();
            ChucNang4_1.Show();
        }
        // Chuc nang 4 - Cau 2
        private void btnVD2_Click(object sender, EventArgs e)
        {
            Ex2 ChucNang4_2 = new Ex2();
            ChucNang4_2.Show();
        }
        // Chuc nang 4 - Cau 3
        private void btnVD3_Click(object sender, EventArgs e)
        {
            Ex3 ChucNang4_3 = new Ex3();
            ChucNang4_3.Show();
        }
        // Chuc nang 4 - Cau 4
        private void btnVD4_Click(object sender, EventArgs e)
        {
            Ex4 ChucNang4_4 = new Ex4();
            ChucNang4_4.Show();
        }
        // Chuc nang 4 - Cau 5
        private void btnVD5_Click(object sender, EventArgs e)
        {
            Ex5 ChucNang4_5 = new Ex5();
            ChucNang4_5.Show();
        }
        // Chuc nang 5 - Cau 1
        private void btnVD6_Click(object sender, EventArgs e)
        {
            Ex6 ChucNang5_1 = new Ex6();
            ChucNang5_1.Show();
        }
        // Chuc nang 5 - Cau 2
        private void btnVD7_Click(object sender, EventArgs e)
        {
            Ex7 ChucNang5_2 = new Ex7();
            ChucNang5_2.Show();
        }
        // Thoat chuong trinh
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
