using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class NhaCungCap_BLL
    {
        NhaCungCap_DAL nccdal = new NhaCungCap_DAL();
       
        //phương thức này gọi phương thức sv_select() ở lớp SinhVien_DAL (tầng DAL)
        public DataTable Select_NhaCungCap()
        {
            return nccdal.ncc_select();
        }

        //phương thức này gọi phương thức sv_insert() ở lớp SinhVien_DAL (tầng DAL)
        public int Insert_NhaCungCap(string MaNhaCungCap, string TenNhaCungCap, string DiaChi, string SĐT)
        {
            return nccdal.ncc_insert(MaNhaCungCap, TenNhaCungCap, DiaChi, SĐT);
        }

        //phương thức này gọi phương thức nv_update() ở lớp NhanVIen_DAL (tầng DAL)
        public int Update_NhaCungCap(string MaNhaCungCap, string TenNhaCungCap, string DiaChi, string SĐT)
        {
            return nccdal.ncc_update(MaNhaCungCap, TenNhaCungCap, DiaChi, SĐT);
        }
        public int Delete_NhaCungCap(string MaNhaCungCap)
        {
            return nccdal.ncc_delete(MaNhaCungCap);
        }
    }
}
