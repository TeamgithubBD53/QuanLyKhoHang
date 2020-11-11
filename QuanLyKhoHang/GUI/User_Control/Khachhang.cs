using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlyKhohang.BUS;

namespace QuanlyKhohang.GUI
{
    public partial class Khachhang : UserControl
    {
        Khachhang_BUS kh = new Khachhang_BUS();

        public Khachhang()
        {
            InitializeComponent();
            kh.bangDuLieu = dataGridView1;
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            kh.ViewAll();
        }
    }
}
