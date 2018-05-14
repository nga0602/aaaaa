using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL
{
    public class KhachHang_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] bien = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable kh_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("Select_KhachHang");
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int kh_insert(string MaKhachHang, string TenKhachHang, string DiaChi, string SĐT)
        {
            //thaotac.KetnoiCSDL();
            bien = new string[4];
            value = new object[4];
            bien[0] = "@MaKhachHang"; value[0] = MaKhachHang;
            bien[1] = "@TenKhachHang"; value[1] = TenKhachHang;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            bien[2] = "@DiaChi"; value[2] = DiaChi;
            bien[3] = "@SĐT"; value[3] = SĐT;
            return thaotac.SQL_ThuchienInsert_KhachHang("Insert_KhachHang", bien, value, 4);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int kh_update(string MaKhachHang, string TenKhachHang, string DiaChi, string SĐT)
        {
            bien = new string[4];
            value = new object[4];
            bien[0] = "@MaKhachHang"; value[0] = MaKhachHang;
            bien[1] = "@TenKhachHang"; value[1] = TenKhachHang;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            bien[2] = "@DiaChi"; value[2] = DiaChi;
            bien[3] = "@SĐT"; value[3] = SĐT;
            return thaotac.SQL_ThuchienUpdate_KhachHang("Update_KhachHang", bien, value, 4);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int kh_delete(string MaKhachHang)
        {
            bien = new string[1];
            value = new object[1];
            bien[0] = "@MaKhachHang"; value[0] = MaKhachHang;
            return thaotac.SQL_ThuchienDelete_KhachHang("Delete_KhachHang", bien, value, 1);
        }
    }
}
