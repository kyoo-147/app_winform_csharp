using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

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
    public partial class Ex1 : Form
    {
        // Khoi tao cac bien gia tri can thiet cho chuong trinh
        private Thread progressBarThread;
        private bool activate;
        private int minValue;
        private int maxValue;
        private int increValue;
        private int interval;

        public Ex1()
        {
            InitializeComponent();
        }
        // Khoi tao logic su kien Click cua Timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            ProgressBar1.PerformStep();
            lbValue.Text = ProgressBar1.Value.ToString();

            if (ProgressBar1.Value >= ProgressBar1.Maximum)
            { 
                ProgressBar1.Value = ProgressBar1.Minimum; 
            }
        }

        private void VD1_Load(object sender, EventArgs e)
        {

        }
        // Su kien nut Stop dung cac gia tri
        private void btnStop_Click_1(object sender, EventArgs e)
        {
            activate = false;
            txtIncrement.ReadOnly = false;
            txtInterval.ReadOnly = false;
            btnStart.Enabled = true;
        }
        // Bat dau logic cho su kien khi nhan nut Start
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            // Kiem tra input nguoi dung
            if (!int.TryParse(txtIncrement.Text, out increValue) || !int.TryParse(txtInterval.Text, out interval))
            {
                MessageBox.Show("Có vẻ bạn đã nhập sai giá trị. Xin vui lòng nhập lại giá trị nhé.");
                return;
            }
            // Logic cho su kien nut Start
            minValue = ProgressBar1.Minimum;
            maxValue = ProgressBar1.Maximum;
            activate = true;
            txtIncrement.ReadOnly = true;
            txtInterval.ReadOnly = true;
            btnStart.Enabled = false;
            progressBarThread = new Thread(UpdateProgressBar);
            progressBarThread.Start();
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lbValue_Click(object sender, EventArgs e)
        {

        }

        // Logic cap nhap gia tri cua thanh tien trinh
        private void UpdateProgressBar()
        {
            int value = minValue;
            while (activate)
            {
                value += increValue;
                if (value >= maxValue)
                {
                    value = minValue;
                }
                Invoke((MethodInvoker)delegate
                {
                    ProgressBar1.Value = value;
                    lbValue.Text = value.ToString();
                }
                ); 
                Thread.Sleep(interval);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}