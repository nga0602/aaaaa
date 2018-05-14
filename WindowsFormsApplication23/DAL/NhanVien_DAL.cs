using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL
{
    public class NhanVien_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] bien = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable sv_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("Select_NhanVien");
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int nv_insert(string MaNhanVien,string TenNhanVien, string DiaChi, string SĐT,bool Gioitinh)
        {
            //thaotac.KetnoiCSDL();
            bien = new string[5];
            value = new object[5];
            bien[0] = "@MaNhanVien"; value[0] = MaNhanVien;
            bien[1] = "@TenNhanVien"; value[1] = TenNhanVien;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            bien[2] = "@DiaChi"; value[2] = DiaChi;
            bien[3] = "@SĐT"; value[3] = SĐT; 
            bien[4] = "@gioitinh";value[4] = Gioitinh;
            return thaotac.SQL_ThuchienInsert_NhanVien("Insert_NhanVien", bien, value, 5);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int nv_update(string MaNhanVien, string TenNhanVien, string DiaChi, string SĐT,bool Gioitinh)
        {
            bien = new string[5];
            value = new object[5];
            bien[0] = "@MaNhanVien"; value[0] = MaNhanVien;
            bien[1] = "@TenNhanVien"; value[1] = TenNhanVien;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            bien[2] = "@DiaChi"; value[2] = DiaChi;
            bien[3] = "@SĐT"; value[3] = SĐT;
            bien[4] = "@gioitinh"; value[4] = Gioitinh;
            return thaotac.SQL_ThuchienUpdate_NhanVien("Update_NhanVien", bien, value, 5);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int nv_delete(string MaNhanVien)
        {
            bien = new string[1];
            value = new object[1];
            bien[0] = "@MaNhanVien"; value[0] = MaNhanVien;
            return thaotac.SQL_ThuchienDelete_NhanVien("Delete_NhanVien", bien, value, 1);
        }
    }
}

