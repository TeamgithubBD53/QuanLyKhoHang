using QuanlyKhohang.BUS;
using QuanlyKhohang.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKhohang.GUI
{
    public partial class Chitietphieunhap : Form
    {
        ChitietPhieunhap_BUS ct = new ChitietPhieunhap_BUS();
        public Chitietphieunhap()
        {
            InitializeComponent();
            ct.sanPham = dataGridView1;
            ct.chiTiet = dataGridView2;
            ct.txtTotal = txtTongtien;
        }
        public void GetValue1(string pnid, string nccid)
        {
            txtPNID1.Text = pnid;
            txtNCCID.Text = nccid;
        }

        private void Chitietphieunhap_Load(object sender, EventArgs e)
        {
            ct.ViewAll(int.Parse(txtPNID1.Text), int.Parse(txtNCCID.Text));
            txtID.Focus();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
