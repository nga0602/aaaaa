using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL
{
    public class HoaDon_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] bien = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable hd_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("Select_HoaDon");
        }




        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int hd_insert (string MaHoaDon, string TenHoaDon, string TenHangHoa, string SoLuong, string MaNhaCungCap, DateTime NgayVietHoaDon, string GiaMatHang)
        {
            //thaotac.KetnoiCSDL();
            bien = new string[7];
            value = new object[7];
            bien[0] = "@MaHoaDon"; value[0] = MaHoaDon;
            bien[1] = "@TenHoaDon"; value[1] = TenHoaDon;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            bien[2] = "@TenHangHoa"; value[2] = TenHangHoa;
            bien[3] = "@SoLuong"; value[3] = SoLuong;
            bien[4] = "@MaNhaCungCap"; value[4] = MaNhaCungCap;
            bien[5] = "@NgayVietHoaDon";value[5] = NgayVietHoaDon;
            bien[6] = "@GiaMatHang"; value[6] = GiaMatHang;
            return thaotac.SQL_ThuchienInsert_HoaDon("Insert_HoaDon", bien, value, 7);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int hd_update(string MaHoaDon, string TenHoaDon, string TenHangHoa, string SoLuong, string MaNhaCungCap, DateTime NgayVietHoaDon, string GiaMatHang)
        {
            bien = new string[7];
            value = new object[7];
            bien[0] = "@MaHoaDon"; value[0] = MaHoaDon;
            bien[1] = "@TenHoaDon"; value[1] = TenHoaDon;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            bien[2] = "@TenHangHoa"; value[2] = TenHangHoa;
            bien[3] = "@SoLuong"; value[3] = SoLuong;
            bien[4] = "@MaNhaCungCap"; value[4] = MaNhaCungCap;
            bien[5] = "@NgayVietHoaDon"; value[5] = NgayVietHoaDon;
            bien[6] = "@GiaMatHang"; value[6] = GiaMatHang;
            return thaotac.SQL_ThuchienInsert_HoaDon("Update_HoaDon", bien, value, 7);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int hd_delete(string MaHoaDon)
        {
            bien = new string[1];
            value = new object[1];
            bien[0] = "@MaHoaDon"; value[0] = MaHoaDon;
            return thaotac.SQL_ThuchienDelete_HoaDon("Delete_HoaDon", bien, value, 1);
        }
    }
}
