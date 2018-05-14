using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class KhachHang_BLL
    {
        KhachHang_DAL khdal = new KhachHang_DAL();
        //phương thức này gọi phương thức sv_select() ở lớp SinhVien_DAL (tầng DAL)
        public DataTable Select_KhachHang()
        {
            return khdal.kh_select();
        }

        //phương thức này gọi phương thức sv_insert() ở lớp SinhVien_DAL (tầng DAL)
        public int Insert_KhachHang(string MaKhachHang, string HoTenKhachHang, string DiaChi, string SĐT)
        {
            return khdal.kh_insert(MaKhachHang, HoTenKhachHang, DiaChi, SĐT);
        }

        //phương thức này gọi phương thức nv_update() ở lớp NhanVIen_DAL (tầng DAL)
        public int Update_KhachHang(string MaKhachHang, string HoTenKhachHang, string DiaChi, string SĐT)
        {
            return khdal.kh_update(MaKhachHang, HoTenKhachHang, DiaChi, SĐT);
        }
        public int Delete_KhachHang(string MaKhachHang)
        {
            return khdal.kh_delete(MaKhachHang);
        }
    }
}
