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
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void VD5_Load(object sender, EventArgs e)
        { }
        // Func su kien nhan Timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime Thoi_Gian_Hien_Tai = DateTime.Now;
            // Dinh dang chuan thoi gian
            string Dinh_Dang_Time = Thoi_Gian_Hien_Tai.ToString("HH:mm:ss");
            // Hien thi thoi gian len label
            txtTime.Text = Dinh_Dang_Time;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Exit chuong trinh
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
