using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class TaiKhoan_BLL
    {
        TaiKhoan_DAL tkdal = new TaiKhoan_DAL();
        //phương thức này gọi phương thức sv_select() ở lớp SinhVien_DAL (tầng DAL)
        public DataTable Select_TaiKhoan()
        {
            return tkdal.tk_select();
        }

        //phương thức này gọi phương thức sv_insert() ở lớp SinhVien_DAL (tầng DAL)
        public int Insert_TaiKhoan(string TaiKhoan, string MatKhau)
        {
            return tkdal.tk_insert(TaiKhoan, MatKhau);
        }

        //phương thức này gọi phương thức nv_update() ở lớp NhanVIen_DAL (tầng DAL)
        public int Update_TaiKhoan(string TaiKhoan, string MatKhau)
        {   
            return tkdal.tk_update(TaiKhoan, MatKhau);
        }
     
        public int Delete_TaiKhoan(string TaiKhoan)
        {
            return tkdal.tk_delete(TaiKhoan);
        }
    }
}
