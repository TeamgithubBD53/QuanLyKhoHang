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
    class Khachhang_BUS
    {
        #region Control
        public DataGridView bangDuLieu { get; set; }
        public DataView dv { get; set; }
        #endregion

        public void ViewAll()
        {
            string sql = string.Format("select * from Khachhang");
            DataTable dt = DataAccess.Query(sql);
            dv = new DataView(dt);
            bangDuLieu.DataSource = dt;
            bangDuLieu.Columns[0].HeaderText = "KHID";
            bangDuLieu.Columns[1].HeaderText = "Tên Khách hàng";
            bangDuLieu.Columns[2].HeaderText = "Địa chỉ";
            bangDuLieu.Columns[3].HeaderText = "Điện thoại";
            bangDuLieu.Columns[4].HeaderText = "Email";
        }

        public void timKiem(string tenkh, string diachi)
        {
            dv.RowFilter = "[TenKH] like '%" + tenkh + "%' and [Diachi] like '%" + diachi + "%'";
            bangDuLieu.DataSource = dv;
        }
        public void Add(string ten,string diachi,string dienthoai,string email)
        {
            DataAccess.NonQuery("Khachhang_insert",
                new SqlParameter("@ten", ten),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@dienthoai", dienthoai),
                new SqlParameter("@email", email));
        }
    }
}
