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
    public partial class Ex2 : Form
    {
        // bien bool cho load form
        private bool continueLoadingForm = false;
        public Ex2()
        {
            InitializeComponent();
            ShowLoadFormMessageBox();
        }
        // Function hien thi trang thai box mess
        private void ShowLoadFormMessageBox()
        {
            var Ket_Qua = MessageBox.Show("Bạn có muốn tiếp tục Load Form không?", "Bùi Minh Cường - 03 - 122001458", MessageBoxButtons.YesNo);
            // Kiem tra ket qua nhan cua su kien load form
            if (Ket_Qua == DialogResult.No)
            { Application.Exit(); }
            else
            { continueLoadingForm = true; }
        }
        // Func chuan hoa
        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            // Hien thi ket qua tu box
            if (!continueLoadingForm)
            {
                ShowLoadFormMessageBox();
                return;
            }
            string dau_vao = txtChuoi.Text.Trim();
            string[] cac_tu = dau_vao.Split(new char[] { ' ', '.', ',', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string Ket_Qua = string.Join(" ", cac_tu);
            txtChuoi.Text = Ket_Qua;
        }

        private void VD2_Load(object sender, EventArgs e)
        {

        }

        private void lvThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Func thong ke
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Hien thi ket qua tu load box
            if (!continueLoadingForm)
            {
                ShowLoadFormMessageBox();
                return;
            }
            lvThongKe.Items.Clear();
            var cac_tu = txtChuoi.Text.ToLower().Split(' ').GroupBy(w => w).Select(g => new { tu_ngu = g.Key, Count = g.Count() });
            // Vong lap tim kiem tu ngu
            foreach (var tu_ngu in cac_tu)
            {
                ListViewItem muc = new ListViewItem(tu_ngu.tu_ngu);
                muc.SubItems.Add(tu_ngu.Count.ToString());
                lvThongKe.Items.Add(muc);
            }
            lvThongKe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            foreach (ColumnHeader column in lvThongKe.Columns)
            {
                column.Width = Math.Max(column.Width, column.Text.Length * 10); 
            }
        }
        // Func luu du lieu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu thành công dữ liệu của người dùng", "Bùi Minh Cường - 03 - 122001458");
            Application.Exit();
        }
    }
}
