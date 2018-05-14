using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class SanPham_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] bien = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable sp_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("Select_SanPham");
        }




        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int sp_insert(string MaHangHoa, string TenHangHoa, string SoLuong, string MaNhaCungCap, string GiaMatHang)
        {
            //thaotac.KetnoiCSDL();
            bien = new string[5];
            value = new object[5];
            bien[0] = "@MaHangHoa"; value[0] = MaHangHoa;
            bien[1] = "@TenHangHoa"; value[1] = TenHangHoa;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            bien[2] = "@SoLuong"; value[2] = SoLuong;
            bien[3] = "@MaNhaCungCap"; value[3] = MaNhaCungCap;
            bien[4] = "@GiaMatHang"; value[4] = GiaMatHang;
            return thaotac.SQL_ThuchienInsert_SanPham("Insert_SanPham", bien, value, 5);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int sp_update(string MaHangHoa, string TenHangHoa, string SoLuong, string MaNhaCungCap, string GiaMatHang)
        {
            bien = new string[5];
            value = new object[5];
            bien[0] = "@MaHangHoa"; value[0] = MaHangHoa;
            bien[1] = "@TenHangHoa"; value[1] = TenHangHoa;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            bien[2] = "@SoLuong"; value[2] = SoLuong;
            bien[3] = "@MaNhaCungCap"; value[3] = MaNhaCungCap;
            bien[4] = "@GiaMatHang"; value[4] = GiaMatHang;
            return thaotac.SQL_ThuchienUpdate_SanPham("Update_SanPham", bien, value, 5);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int sp_delete(string MaHangHoa)
        {
            bien = new string[1];
            value = new object[1];
            bien[0] = "@MaHangHoa"; value[0] = MaHangHoa;
        return thaotac.SQL_ThuchienDelete_SanPham("Delete_SanPham", bien, value, 1);
        }
    }
}
