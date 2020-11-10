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
using QuanlyKhohang.DataLayer;
using QuanlyKhohang.GUI;

namespace QuanlyKhohang.GUI
{
    public partial class Phieuxuat : UserControl
    {
        Phieuxuat_BUS px = new Phieuxuat_BUS();
        public Phieuxuat()
        {
            InitializeComponent();
            px.bangDuLieu = dataGridView1;
        }
        private void Phieuxuat_Load_1(object sender, EventArgs e)
        {
            px.ViewAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPXID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNhanvien.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtPNgayxuat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTongsoluong.Text = DataAccess.Query("select * from GetAmount1(" + txtPXID.Text + ")").Rows[0][0].ToString();
            txtTongtien.Text = DataAccess.Query("select * from GetTotal1(" + txtPXID.Text + ")").Rows[0][0].ToString();
            txtKHID.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtNVID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
        #region Get Infomation
        public void GetValueKH(string id, string name)
        {
            txtKH.Text = name;
            txtKHID.Text = id;
        }
        private void btnKH_Click(object sender, EventArgs e)
        {
            Form_KH KH = new Form_KH();
            KH.Getmydata = new Form_KH.GetData(GetValueKH);
            KH.ShowDialog();
        }
        public void GetValueNV(string id, string name)
        {
            txtNhanvien.Text = name;
            txtNVID.Text = id;
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            Form_NV nv = new Form_NV();
            nv.Getmydata = new Form_NV.GetData(GetValueNV);
            nv.ShowDialog();
        }
        #endregion

        


    }
}
