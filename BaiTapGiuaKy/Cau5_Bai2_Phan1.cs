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
    public partial class Cau5_Bai1 : Form
    {
        public Cau5_Bai1()
        {
            InitializeComponent();
        }
        // Func su kien them du lieu
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtHocBong.Text) || cboLop.SelectedItem == null)
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin của bạn.");
                return;
            }
            // Mang luu tru du lieu 
            var muc = new ListViewItem(new[] { txtTen.Text, cboLop.SelectedItem.ToString(), txtHocBong.Text });
            lvDanhSach.Items.Add(muc);
            // Lam sach ten va hoc bong
            txtTen.Clear();
            txtHocBong.Clear();
            cboLop.SelectedIndex = -1;
        }
        private void txtHocBong_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
        }
        // Them thong tin va du lieu
        private void BT1_Load(object sender, EventArgs e)
        {
            // Them du lieu
            lvDanhSach.Columns.Add("Họ Tên", 100);
            lvDanhSach.Columns.Add("Lớp", 100);
            lvDanhSach.Columns.Add("Học Bổng", 100);
        }
        // Luu danh sach vao file txt
        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter("Danh_Sach_Hoc_Bong_CNTT.txt"))
            {
                foreach (ListViewItem item in lvDanhSach.Items)
                {
                    sw.WriteLine("{item.SubItems[0].Text}\t{item.SubItems[1].Text}\t{item.SubItems[2].Text}");
                }
                MessageBox.Show("Dữ liệu của bạn đã được lưu thành công.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        
    }
}
