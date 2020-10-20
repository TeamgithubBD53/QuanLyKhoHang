using QuanlyKhohang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKhohang.BUS
{
    class Sanpham_BUS
    {

        #region Control
        public DataGridView bangDuLieu { get; set; }
        public DataView dv { get; set; }
        #endregion
        public void ViewAll()
        {
            string sql = string.Format("Sanpham_view");
            DataTable dt = DataAccess.Query(sql);
            bangDuLieu.DataSource = dt;
            dv = new DataView(dt);
            bangDuLieu.Columns[0].HeaderText = "ID";
            bangDuLieu.Columns[1].HeaderText = "Tên sản phẩm";
            bangDuLieu.Columns[2].HeaderText = "Nhà cung cấp";
            bangDuLieu.Columns[3].HeaderText = "Giá";
            bangDuLieu.Columns[4].HeaderText = "Số lượng";
            bangDuLieu.Columns[5].Visible = false;
        }
    }
}
