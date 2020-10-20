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
    class ChitietPhieunhap_BUS
    {
        public TextBox txtTotal { get; set; }
        public DataGridView sanPham { get; set; }
        public DataGridView chiTiet { get; set; }
        public void Insert_Update(int pnid, int spid, int soluong)
        {
            DataAccess.NonQuery("Chitietphieunhap_insert_update",
                new SqlParameter("@pnid", pnid),
                new SqlParameter("@spid", spid),
                new SqlParameter("@soluong", soluong));
        }
        public void Update(int pnid, int spid, int soluong)
        {
            DataAccess.NonQuery("Chitietphieunhap_update",
                new SqlParameter("@pnid", pnid),
                new SqlParameter("@spid", spid),
                new SqlParameter("@soluong", soluong));
        }
        public void Delete(int pnid, int spid)
        {
            DataAccess.NonQuery("Chitietphieunhap_delete",
                new SqlParameter("@pnid", pnid),
                new SqlParameter("@spid", spid));
        }
    }

}
