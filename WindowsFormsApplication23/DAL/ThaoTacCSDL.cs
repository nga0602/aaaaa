using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
     public class ThaoTacCSDL
    {
        SqlConnection GetConnection;
        private void KetnoiCSDL()
        {
            GetConnection = new SqlConnection(@"Data Source=DESKTOP-49Q2S97\SQLEXPRESS;Initial Catalog=laptrinhungdung;Integrated Security=True;User ID=sa;Password=admin1234");
            GetConnection.Open();

        }
        private void NgatKetNoi()
        {
            GetConnection.Close();
            GetConnection.Dispose();
        }

        //phương thức thực thi Select dữ liệu
        public DataTable SQL_Laydulieu(string Select_NhanVien)
        {
            KetnoiCSDL();
            //thực thi lấy dữ liệu từ CSDL
            SqlCommand cmd = new SqlCommand("Select_NhanVien", GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //ngắt kết nối
            NgatKetNoi();
            //trả về bảng chứa dữ liệu lấy được.
            return dt;
        }
        public int SQL_ThuchienSelect_NhanVien(string Select_NhanVien, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Select_NhanVien, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienInsert_NhanVien(string Insert_NhanVien, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Insert_NhanVien, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienUpdate_NhanVien(string Update_NhanVien, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Update_NhanVien, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienDelete_NhanVien(string Delete_NhanVien, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Delete_NhanVien, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public DataTable SQL_Laydulieu1(string Select_KhachHang)
        {
            KetnoiCSDL();
            //thực thi lấy dữ liệu từ CSDL
            SqlCommand cmd1 = new SqlCommand("Select_KhachHang", GetConnection);
            cmd1.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //ngắt kết nối
            NgatKetNoi();
            //trả về bảng chứa dữ liệu lấy được.
            return dt;
        }
        public int SQL_ThuchienSelect_KhachHang(string Select_KhachHang, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Select_KhachHang, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienInsert_KhachHang(string Insert_KhachHang, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Insert_KhachHang, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienUpdate_KhachHang(string Update_KhachHang, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Update_KhachHang, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienDelete_KhachHang(string Delete_KhachHang, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Delete_KhachHang, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public DataTable SQL_Laydulieu2(string Select_NhaCungCap)
        {
            KetnoiCSDL();
            //thực thi lấy dữ liệu từ CSDL
            SqlCommand cmd2 = new SqlCommand("Select_NhaCungCap", GetConnection);
            cmd2.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //ngắt kết nối
            NgatKetNoi();
            //trả về bảng chứa dữ liệu lấy được.
            return dt;
        }
        public int SQL_ThuchienSelect_NhaCungCap(string Select_KhachHang, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Select_KhachHang, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienInsert_NhaCungCap(string Insert_NhaCungCap, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Insert_NhaCungCap, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienUpdate_NhaCungCap(string Update_NhaCungCap, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Update_NhaCungCap, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienDelete_NhaCungCap(string Delete_NhaCungCap, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Delete_NhaCungCap, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public DataTable SQL_Laydulieu3(string Select_SanPham)
        {
            KetnoiCSDL();
            //thực thi lấy dữ liệu từ CSDL
            SqlCommand cmd3= new SqlCommand("Select_SanPham", GetConnection);
            cmd3.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //ngắt kết nối
            NgatKetNoi();
            //trả về bảng chứa dữ liệu lấy được.
            return dt;
        }
        public int SQL_ThuchienSelect_SanPham(string Select_KhachHang, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Select_KhachHang, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienInsert_SanPham(string Insert_SanPham, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Insert_SanPham, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienUpdate_SanPham(string Update_SanPham, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Update_SanPham, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienDelete_SanPham(string Delete_SanPham, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Delete_SanPham, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public DataTable SQL_Laydulieu5(string Select_HoaDon)
        {
            KetnoiCSDL();
            //thực thi lấy dữ liệu từ CSDL
            SqlCommand cmd3 = new SqlCommand("Select_HoaDon", GetConnection);
            cmd3.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //ngắt kết nối
            NgatKetNoi();
            //trả về bảng chứa dữ liệu lấy được.
            return dt;
        }
        public int SQL_ThuchienSelect_HoaDon(string Select_HoaDon, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Select_HoaDon, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienInsert_HoaDon(string Insert_HoaDon, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Insert_HoaDon, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienUpdate_HoaDon(string Update_HoaDon, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Update_HoaDon, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienDelete_HoaDon(string Delete_HoaDon, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Delete_HoaDon, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        //TaiKhoan
        public DataTable SQL_Laydulieu6(string Select_TaiKhoan)
        {
            KetnoiCSDL();
            //thực thi lấy dữ liệu từ CSDL
            SqlCommand cmd3 = new SqlCommand("Select_TaiKhoan", GetConnection);
            cmd3.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //ngắt kết nối
            NgatKetNoi();
            //trả về bảng chứa dữ liệu lấy được.
            return dt;
        }
        public int SQL_ThuchienSelect_TaiKhoan(string Select_TaiKhoan, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Select_TaiKhoan, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienInsert_TaiKhoan(string Insert_TaiKhoan, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Insert_TaiKhoan, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienUpdate_TaiKhoan(string Update_TaiKhoan, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Update_TaiKhoan, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int SQL_ThuchienDelete_TaiKhoan(string Delete_TaiKhoan, string[] bien, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Delete_TaiKhoan, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(bien[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }









    }
}
