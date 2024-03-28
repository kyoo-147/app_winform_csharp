using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }
        // Func hien thi cay thu muc
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // khoi tao cac nut cua cay
            TreeView.Nodes[0].Nodes.Clear();
            string[] O_Dia = Directory.GetLogicalDrives();
            foreach (string drive in O_Dia)
            {
                TreeNode Nut_O_Dia = TreeView.Nodes[0].Nodes.Add(drive);
                // Nut o dia o vi tri 0
                Nut_O_Dia.ImageIndex = 0; 
                string[] Tu_Dien = Directory.GetDirectories(drive);
                foreach (string directory in Tu_Dien)
                {
                    TreeNode Dia_Chi_Nut = Nut_O_Dia.Nodes.Add(Path.GetFileName(directory));
                    Dia_Chi_Nut.ImageIndex = 1; 
                }
            }
        }

        private void VD4_Load(object sender, EventArgs e)
        {
            TreeView.Nodes.Add("Thư mục máy tính của bạn.");
            // bat su kien hien thi nut cua cay thu muc
            btnHienThi.Click += btnHienThi_Click;
        }
        // Exit chuong trinh
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
