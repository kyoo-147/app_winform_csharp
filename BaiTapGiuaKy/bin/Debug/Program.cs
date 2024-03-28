using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapGiuaKy_BuiMinhCuong
////////////////////////////////////////////////////////
//                       _oo0oo_                      //
//                      o8888888o                     //
//                      88" . "88                     // 
//                      (| -_- |)                     //
//                      0\  =  /0                     //
//                    ___/`---'\___                   // 
//                  .' \\|     |// '.                 //
//                 / \\|||  :  |||// \                //
//                / _||||| -:- |||||- \               //
//               |   | \\\  -  /// |   |              //
//               | \_|  ''\---/''  |_/ |              // 
//               \  .-\__  '-'  ___/-. /              //
//             ___'. .'  /--.--\  `. .'___            //
//          ."" '<  `.___\_<|>_/___.' >' "".          //
//         | | :  `- \`.;`\ _ /`;.`/ - ` : | |        // 
//         \  \ `_.   \_ __\ /__ _/   .-` /  /        //
//     =====`-.____`.___ \_____/___.-`___.-'=====     // 
//                       `=---='                      //
//                                                    //
//     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~     //
//          Khoa: Công Nghệ Thông Tin                 //
//          Lớp: 22CT115                              //
//          MSSV: 122001458                           //
//          STT: 06 - Số máy: 03                      //
//          Tên: Bùi Minh Cường - Lớp Trưởng          //
//          Môn: Lập trình trên môi trường Windows    //
//                                                    //
////////////////////////////////////////////////////////
{
    static class Program
    {
        /// </bản tóm tắt>
        /// Điểm vào chính của ứng dụng.
        /// </bản tóm tắt>
        [STAThread]
        // Giao dien chinh chuong trinh khoi dong
        // Dai Hoc Lac Hong LHU
        // 22CT115 - Bui Minh Cuong - 122001458 - STT: 06 - So May: 03
        // Mon: Lap trinh tren moi truong Windows
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Goi ham Main: noi se goi cac giao dien cua cac chuc nang khac
            Application.Run(new Main());
        }
    }
}
