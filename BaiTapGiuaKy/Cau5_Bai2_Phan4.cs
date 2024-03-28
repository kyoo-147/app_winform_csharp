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
    public partial class Cau5_Bai4 : Form
    {
        // Khoi tao va dinh nghia cac bien
        private List<Point> Diem = new List<Point>();
        // Gia tri mac dinh sai
        private bool Su_Kien_Ve = false;
        public Cau5_Bai4()
        {
            InitializeComponent();
        }
        // Bat su kien chuot xuong - down
        private void BT4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Them vi tri cua su kien
                Su_Kien_Ve = true;
                Diem.Add(e.Location);
            }
        }
        // Bat su kien di chuyen chuot
        private void BT4_MouseMove(object sender, MouseEventArgs e)
        {
            if (Su_Kien_Ve)
            {
                // Them vi tri cua su kien
                Diem.Add(e.Location);
                Invalidate();
            }
        }
        private void BT4_Load(object sender, EventArgs e)
        {
        }
        // Bat su kien chuot len - up
        private void BT4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Su_Kien_Ve = false;
            }
        }
        // Func su kien ve
        private void BT4_Paint(object sender, PaintEventArgs e)
        {
            if (Diem.Count > 1)
            {
                // Ve va hien thi duong ve len giao dien
                e.Graphics.DrawLines(Pens.Red, Diem.ToArray());
            }
        }
    }
}
