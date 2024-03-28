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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
            InitializeTooltips();
        }
        // Su kien tooltip
        private void InitializeTooltips()
        {
            ttpNgaySinh.SetToolTip(txtNgaySinh, "Vui lòng nhập ngày sinh theo chuẩn định dạng: dd/MM/yyyy");
            ttpDiemTB.SetToolTip(txtDiemTB, "Vui lòng nhập điểm trung bình theo chuẩn là số.");
        }

        private void VD3_Load(object sender, EventArgs e)
        {

        }
        // Func logic kiem tra dieu kien
        private void Check_Dieu_Kien()
        {
            DateTime Ngay_Sinh;
            // kiem tra dau vao ngay sinh
            if (!DateTime.TryParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out Ngay_Sinh))
            {
                MessageBox.Show("Ngày sinh của bạn không hợp lệ. Vui lòng nhập ngày sinh theo chuẩn định dạng: dd/MM/yyyy.", "Phát Hiện Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiem tra diem trung binh
            double Diem_Trung_Binh;
            if (!double.TryParse(txtDiemTB.Text, out Diem_Trung_Binh))
            {
                MessageBox.Show("Điểm trung bình của bạn nhập không hợp lệ. Hãy vui lòng nhập số.", "Phát Hiện Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Bạn đã đăng ký thành công!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Check_Dieu_Kien();
        }
        // Exit chuong trinh
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
