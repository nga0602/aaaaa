using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class TaiKhoan_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] bien = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable tk_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("Select_TaiKhoan");
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int tk_insert(string TaiKhoan, string MatKhau)
        {
            //thaotac.KetnoiCSDL();
            bien = new string[2];
            value = new object[2];
            bien[0] = "@TaiKhoan"; value[0] = TaiKhoan;
            bien[1] = "@MatKhau"; value[1] = MatKhau;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
           
            return thaotac.SQL_ThuchienInsert_TaiKhoan("Insert_TaiKhoan", bien, value, 2);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int tk_update(string TaiKhoan, string MatKhau)
        {
            bien = new string[2];
            value = new object[2];
            bien[0] = "@TaiKhoan"; value[0] = TaiKhoan;
            bien[1] = "@MatKhau"; value[1] = MatKhau;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
          
            
            return thaotac.SQL_ThuchienUpdate_TaiKhoan("Update_TaiKhoan", bien, value, 2);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int tk_delete(string TaiKhoan)
        {
            bien = new string[1];
            value = new object[1];
            bien[0] = "@TaiKhoan"; value[0] = TaiKhoan;
            return thaotac.SQL_ThuchienDelete_TaiKhoan("Delete_TaiKhoan", bien, value, 1);
        }
    }
}
