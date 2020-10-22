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
using GUI;

namespace QuanlyKhohang.GUI
{
    public partial class Sanpham : UserControl
    {
        Sanpham_BUS sp = new Sanpham_BUS();
        public Sanpham()
        {
            InitializeComponent();
            sp.bangDuLieu = dataGridView1;
        }
        private void Sanpham_Load(object sender, EventArgs e)
        {
            sp.ViewAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtSPID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNCC.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtGia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSoluong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtNCCID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        public void GetValue(string id, string name)
        {
            txtNCCID.Text = id;
            txtNCC.Text = name;
        }
    }
}
