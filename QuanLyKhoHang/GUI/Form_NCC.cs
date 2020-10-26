using QuanlyKhohang;
using QuanlyKhohang.BUS;
using QuanlyKhohang.DataLayer;
using QuanlyKhohang.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_NCC : Form
    {
        public Form_NCC()
        {
            InitializeComponent();
        }
        public delegate void GetData(string id, string name);
        public GetData Getmydata;

        private void Form_NCC_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.Query("select * from Nhacungcap");
            dataGridView1.DataSource = dt;
        }
    }
}
