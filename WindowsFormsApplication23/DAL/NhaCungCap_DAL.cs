using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class NhaCungCap_DAL
    {

        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] bien = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable ncc_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu2("Select_NhaCungCap");
        }

        
      

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int ncc_insert(string MaNhaCungCap, string TenNhaCungCap, string DiaChi, string SĐT)
        {
            //thaotac.KetnoiCSDL();
            bien = new string[4];
            value = new object[4];
            bien[0] = "@MaNhaCungCap"; value[0] = MaNhaCungCap;
            bien[1] = "@TenNhaCungCap"; value[1] = TenNhaCungCap;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            bien[2] = "@DiaChi"; value[2] = DiaChi;
            bien[3] = "@SĐT"; value[3] = SĐT;
            return thaotac.SQL_ThuchienInsert_NhaCungCap("Insert_NhaCungCap", bien, value, 4);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int ncc_update(string MaNhaCungCap, string TenNhaCungCap, string DiaChi, string SĐT)
        {
            bien = new string[4];
            value = new object[4];
            bien[0] = "@MaNhaCungCap"; value[0] = MaNhaCungCap;
            bien[1] = "@TenNhaCungCap"; value[1] = TenNhaCungCap;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            bien[2] = "@DiaChi"; value[2] = DiaChi;
            bien[3] = "@SĐT"; value[3] = SĐT;
            return thaotac.SQL_ThuchienUpdate_NhaCungCap("Update_NhaCungCap", bien, value, 4);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int ncc_delete(string MaNhaCungCap)
        {
            bien = new string[1];
            value = new object[1];
            bien[0] = "@MaNhaCungCap"; value[0] = MaNhaCungCap;
            return thaotac.SQL_ThuchienDelete_KhachHang("Delete_NhaCungCap", bien, value, 1);
        }
    }
}
