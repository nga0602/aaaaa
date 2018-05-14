using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication23
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       // public static int Quyen;
        public static string TaiKhoan;
        public static string MatKhau;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhap());
        }
    }
}
