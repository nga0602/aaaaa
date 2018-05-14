using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BLL
{
    public class SanPham_BLL
    {
        SanPham_DAL spdal = new SanPham_DAL();
        //phương thức này gọi phương thức sv_select() ở lớp SinhVien_DAL (tầng DAL)
        public DataTable Select_SanPham()
        {
            return spdal.sp_select();
        }

        //phương thức này gọi phương thức sv_insert() ở lớp SinhVien_DAL (tầng DAL)
        public int Insert_SanPham(string MaHangHoa, string TenHangHoa, string SoLuong, string MaNhaCungCap, string GiaMatHang)
        {
            return spdal.sp_insert(MaHangHoa, TenHangHoa, SoLuong, MaNhaCungCap, GiaMatHang);
        }

        //phương thức này gọi phương thức nv_update() ở lớp NhanVIen_DAL (tầng DAL)
        public int Update_SanPham(string MaHangHoa, string TenHangHoa, string SoLuong, string MaNhaCungCap, string GiaMatHang)
        {           
            return spdal.sp_update(MaHangHoa, TenHangHoa, SoLuong, MaNhaCungCap, GiaMatHang);
        }
        public int Delete_SanPham(string MaHangHoa)
        {
            return spdal.sp_delete(MaHangHoa);
        }
    }
}
