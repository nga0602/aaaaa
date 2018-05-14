using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication23
{
    public partial class DangNhap : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        string connstring = @"Data Source = DESKTOP-49Q2S97\SQLEXPRESS; Initial Catalog = laptrinhungdung; Integrated Security = True";


        DataSet ds;
        string sql;
        DataTable dt;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Cần nhập tài khoản để đăng nhập!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else

                if (textBox2.Text == "")
                MessageBox.Show("Cần nhập mật khẩu để đăng nhập!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                cn = new SqlConnection(@"Data Source = DESKTOP-49Q2S97\SQLEXPRESS; Initial Catalog = laptrinhungdung; Integrated Security = True");
                sql = "select * from DangNhap where TaiKhoan = N'" + textBox1.Text.ToString() + "'and MatKhau = N'" + textBox2.Text.ToString() + "'";
                da = new SqlDataAdapter(sql, cn);
                ds = new DataSet("TaiKhoan");
                da.Fill(ds, "TaiKhoan");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Form1 frm = new Form1();
                 // Program.Quyen = int.Parse(ds.Tables[0].Rows[0][2].ToString());
                    Program.TaiKhoan = (ds.Tables[0].Rows[0][0].ToString());
                    Program.MatKhau = (ds.Tables[0].Rows[0][1].ToString()); ;
                    frm.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng. Vui lòng nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
