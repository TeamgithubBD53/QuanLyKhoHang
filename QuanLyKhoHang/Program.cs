using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlyKhohang.GUI;

namespace QuanlyKhohang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Form_NCC());
=======
            Application.Run(new QLKhohang());
>>>>>>> 0a9849b0908fe0b32430a1618ee65a57aa89568a
        }
    }
}
