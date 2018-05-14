using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class HoaDon_BLL
    {
      
            HoaDon_DAL hddal = new HoaDon_DAL();
            //phương thức này gọi phương thức sv_select() ở lớp SinhVien_DAL (tầng DAL)
            public DataTable Select_HoaDon()
            {
                return hddal.hd_select();
            }

            //phương thức này gọi phương thức sv_insert() ở lớp SinhVien_DAL (tầng DAL)
            public int Insert_HoaDon(string MaHoaDon, string TenHoaDon, string TenHangHoa, string SoLuong, string MaNhaCungCap, DateTime  NgayVietHoaDon, string GiaMatHang)
            {
                return hddal.hd_insert(MaHoaDon, TenHoaDon, TenHangHoa, SoLuong, MaNhaCungCap, NgayVietHoaDon, GiaMatHang);
            }

            //phương thức này gọi phương thức nv_update() ở lớp NhanVIen_DAL (tầng DAL)
            public int Update_HoaDon(string MaHoaDon, string TenHoaDon, string TenHangHoa, string SoLuong, string MaNhaCungCap, DateTime  NgayVietHoaDon, string GiaMatHang)
            {
                return hddal.hd_update(MaHoaDon, TenHoaDon, TenHangHoa, SoLuong, MaNhaCungCap,  NgayVietHoaDon, GiaMatHang);
            }
            public int Delete_HoaDon(string MaHoaDon)
            {
                return hddal.hd_delete(MaHoaDon);
            }
        }
    }

