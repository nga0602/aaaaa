using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class NhanVien_BLL
    {
             NhanVien_DAL nvdal = new NhanVien_DAL();
            //phương thức này gọi phương thức sv_select() ở lớp SinhVien_DAL (tầng DAL)
            public DataTable Select_NhanVien()
            {
                return nvdal.sv_select();
            }

            //phương thức này gọi phương thức sv_insert() ở lớp SinhVien_DAL (tầng DAL)
            public int Insert_NhanVien(string MaNhanVien, string HoTenNhanVien, string DiaChi, string SĐT,bool thoigian)
            {
                return nvdal.nv_insert(MaNhanVien,HoTenNhanVien, DiaChi, SĐT,thoigian);
            }

            //phương thức này gọi phương thức nv_update() ở lớp NhanVIen_DAL (tầng DAL)
            public int Update_NhanVien(string MaNhanVien, string HoTenNhanVien, string DiaChi, string SĐT,bool thoigian)
            {
                return nvdal.nv_update(MaNhanVien, HoTenNhanVien, DiaChi, SĐT,thoigian);
            }
        public int Delete_NhanVien(string MaNhanVien)
        {
            return nvdal.nv_delete(MaNhanVien);
        }   
    }
}


        