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
    public partial class Cau5_Bai2 : Form
    {
        public Cau5_Bai2()
        {
            InitializeComponent();
        }
        private void clSoThich_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cboMau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Nut nhan su kien mau sac
        private void btnMauBanThich_Click(object sender, EventArgs e)
        {
            string Mau_Sac = cboMau.SelectedItem.ToString();
            MessageBox.Show(string.Format("Màu bạn thích là: " + Mau_Sac));
        }
        // Nut nhan su kien so thich
        private void btnSoThichCuaBan_Click(object sender, EventArgs e)
        {
           string lua_chon = "";
           foreach (var Muc_Lua_Chon in clSoThich.CheckedItems)
           {
               string Chon_Muc = Muc_Lua_Chon.ToString();
               lua_chon = lua_chon + " " + Chon_Muc;          
           }
           MessageBox.Show(string.Format("Sở thích của bạn là: " + lua_chon));
        }
        private void BT2_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}