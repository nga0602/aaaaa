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
using BLL;
namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        NhanVien_BLL nvbll = new NhanVien_BLL();
        KhachHang_BLL khbll = new KhachHang_BLL();
        NhaCungCap_BLL nccbll = new NhaCungCap_BLL();
        SanPham_BLL spbll = new SanPham_BLL();
        HoaDon_BLL hdbll = new HoaDon_BLL();
        TaiKhoan_BLL tkbll = new TaiKhoan_BLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox5.Enabled = true;

        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            
            textBox10.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            comboBox3.Enabled = true;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectnhanvien();
            connectkhachhang();
            connectnhacungcap();
            connectsanpham();
            connecttaikhoan();
            connecthoadon();
            load_hoadon();
            load_hanghoa();
            load_ncc();
            UserControl1 us1 = new UserControl1();
            panel1.Controls.Add(us1);
        }
        private void connectnhanvien()
        {
            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-49Q2S97\SQLEXPRESS; Initial Catalog = laptrinhungdung; Integrated Security = True");
            kn.Open();
            string sql = "select * from NhanVien";
            SqlCommand cm = new SqlCommand(sql, kn);/// thực thi sql
            SqlDataAdapter adapter = new SqlDataAdapter(cm);// chuyển đổi data
            DataTable dttable = new DataTable();  //table chứa dữ liệu đổ về
            adapter.Fill(dttable);
            dataGridView1.DataSource = dttable;
            kn.Close();
        }

        private void connectkhachhang()
        {
            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-49Q2S97\SQLEXPRESS; Initial Catalog = laptrinhungdung; Integrated Security = True");
            kn.Open();
            string sql = "select * from KhachHang";
            SqlCommand cm = new SqlCommand(sql, kn);/// thực thi sql
            SqlDataAdapter adapter = new SqlDataAdapter(cm);// chuyển đổi data
            DataTable dttable = new DataTable();  //table chứa dữ liệu đổ về
            adapter.Fill(dttable);
            dataGridView2.DataSource = dttable;
            kn.Close();
        }
        private void connectnhacungcap()
        {
            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-49Q2S97\SQLEXPRESS; Initial Catalog = laptrinhungdung; Integrated Security = True");
            kn.Open();
            string sql = "select * from NhaCungCap";
            SqlCommand cm = new SqlCommand(sql, kn);/// thực thi sql
            SqlDataAdapter adapter = new SqlDataAdapter(cm);// chuyển đổi data
            DataTable dttable = new DataTable();  //table chứa dữ liệu đổ về
            adapter.Fill(dttable);
            dataGridView3.DataSource = dttable;
            kn.Close();
        }
        private void connectsanpham()
        {
            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-49Q2S97\SQLEXPRESS; Initial Catalog = laptrinhungdung; Integrated Security = True");
            kn.Open();
            string sql = "select * from SanPham";
            SqlCommand cm = new SqlCommand(sql, kn);/// thực thi sql
            SqlDataAdapter adapter = new SqlDataAdapter(cm);// chuyển đổi data
            DataTable dttable = new DataTable();  //table chứa dữ liệu đổ về
            adapter.Fill(dttable);
            dataGridView4.DataSource = dttable;
            kn.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox1.Enabled = true;

        }

      

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            textBox14.Text = null;
            textBox15.Text = null;
            textBox13.Text = null;
            comboBox2.Text = null;
            textBox14.Enabled = true;
            textBox19.Text = null;
            

        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            string Add;
            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP - 49Q2S97\SQLEXPRESS; Initial Catalog = laptrinhungdung; Integrated Security = True");
            kn.Open();
            Add = "insert into NhanVien values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + textBox4.Text + "')";
            SqlCommand cm = new SqlCommand(Add, kn);
            cm.ExecuteNonQuery();
            kn.Close();
            connectnhanvien();

        }
        public bool rdo_gioitinh()
        {
            if (radioButton2.Checked == true)
                return false;
            else
                return true;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            nvbll.Update_NhanVien(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text, rdo_gioitinh());
            connectnhanvien();

        }

        private void simpleButton10_Click_1(object sender, EventArgs e)
        {

            nvbll.Insert_NhanVien(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text, rdo_gioitinh());
            connectnhanvien();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            nvbll.Delete_NhanVien(textBox1.Text);
            connectnhanvien();

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            khbll.Update_KhachHang(textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
            connectkhachhang();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            khbll.Delete_KhachHang(textBox5.Text);
            connectkhachhang();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            khbll.Insert_KhachHang(textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
            connectkhachhang();
        }


        private void simpleButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            nccbll.Update_NhaCungCap(comboBox3.SelectedValue.ToString(), textBox10.Text, textBox11.Text, textBox12.Text);
            connectnhacungcap();
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            nccbll.Delete_NhaCungCap(comboBox3.SelectedValue.ToString());
            connectnhacungcap();
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            nccbll.Insert_NhaCungCap(sinhmatudong(), textBox10.Text, textBox11.Text, textBox12.Text);

            connectnhacungcap();
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            spbll.Update_SanPham(textBox14.Text, textBox15.Text, textBox13.Text, comboBox2.Text, textBox19.Text);
            connectsanpham();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            spbll.Delete_SanPham(textBox14.Text);
            connectsanpham();
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            spbll.Insert_SanPham(textBox14.Text, textBox15.Text, textBox13.Text, comboBox2.SelectedValue.ToString(), textBox19.Text);
            connectsanpham();
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView5.CurrentRow.Index;
            textBox17.Text = dataGridView5.Rows[index].Cells[0].Value.ToString();
            textBox18.Text = dataGridView5.Rows[index].Cells[1].Value.ToString();

        }
        private void connecttaikhoan()
        {
            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-49Q2S97\SQLEXPRESS; Initial Catalog = laptrinhungdung; Integrated Security = True");
            kn.Open();
            string sql = "select * from DangNhap";
            SqlCommand cm = new SqlCommand(sql, kn);/// thực thi sql
            SqlDataAdapter adapter = new SqlDataAdapter(cm);// chuyển đổi data
            DataTable dttable = new DataTable();  //table chứa dữ liệu đổ về
            adapter.Fill(dttable);
            dataGridView5.DataSource = dttable;
            kn.Close();
        }
        int index;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            //x` MessageBox.Show(index.ToString());
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            if (dataGridView1.Rows[index].Cells[4].Value.ToString() == "True")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }


        int index6;
        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index6 = dataGridView6.CurrentRow.Index;
            //x` MessageBox.Show(index.ToString());
            textBox20.Text = dataGridView6.Rows[index6].Cells[0].Value.ToString();
            textBox21.Text = dataGridView6.Rows[index6].Cells[1].Value.ToString();
            textBox22.Text = dataGridView6.Rows[index6].Cells[2].Value.ToString();
            textBox23.Text = dataGridView6.Rows[index6].Cells[3].Value.ToString();
           comboBox1.Text = dataGridView6.Rows[index6].Cells[4].Value.ToString();
            dateTimePicker1.Value = ((DateTime)dataGridView6.Rows[index6].Cells[5].Value);
            textBox25.Text = dataGridView6.Rows[index6].Cells[6].Value.ToString();
        }
        private void connecthoadon()
        {
            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-49Q2S97\SQLEXPRESS; Initial Catalog = laptrinhungdung; Integrated Security = True");
            kn.Open();
            string sql = "select * from HoaDon";
            SqlCommand cm = new SqlCommand(sql, kn);/// thực thi sql
            SqlDataAdapter adapter = new SqlDataAdapter(cm);// chuyển đổi data
            DataTable dttable = new DataTable();  //table chứa dữ liệu đổ về
            adapter.Fill(dttable);
            dataGridView6.DataSource = dttable;
            kn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Hide();
        }
        int index1;
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index1 = dataGridView2.CurrentRow.Index;
            //x` MessageBox.Show(index.ToString());
            textBox5.Text = dataGridView2.Rows[index1].Cells[0].Value.ToString();
            textBox6.Text = dataGridView2.Rows[index1].Cells[1].Value.ToString();
            textBox7.Text = dataGridView2.Rows[index1].Cells[2].Value.ToString();
            textBox8.Text = dataGridView2.Rows[index1].Cells[3].Value.ToString();



        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            textBox20.Text = null;
            textBox21.Text = null;
            textBox22.Text = null;
            textBox23.Text = null;
           // textBox24.Text = null;
            //dateTimePicker1 = null;
            textBox20.Enabled = true;
            textBox25.Text = null;
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            hdbll.Update_HoaDon(textBox20.Text, textBox21.Text, textBox22.Text, textBox23.Text, comboBox1.SelectedValue.ToString(), dateTimePicker1.Value, textBox25.Text);
            connecthoadon();
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            hdbll.Delete_HoaDon(textBox20.Text);
            connecthoadon();
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
      
           hdbll.Insert_HoaDon(textBox20.Text, textBox21.Text, textBox22.Text, textBox23.Text, comboBox1.SelectedValue.ToString(), dateTimePicker1.Value, textBox25.Text);
            connecthoadon();
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            textBox17.Text = null;
            textBox18.Text = null;
            textBox17.Enabled = true;
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            tkbll.Update_TaiKhoan(textBox17.Text, textBox18.Text);
            connecttaikhoan();
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            tkbll.Delete_TaiKhoan(textBox17.Text);
            connecttaikhoan();
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            tkbll.Insert_TaiKhoan(textBox17.Text, textBox18.Text);
            connecttaikhoan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox25(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView4.CurrentRow.Index;
            //x` MessageBox.Show(index.ToString());
            textBox14.Text = dataGridView4.Rows[index].Cells[0].Value.ToString();
            textBox15.Text = dataGridView4.Rows[index].Cells[1].Value.ToString();
            textBox13.Text = dataGridView4.Rows[index].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView4.Rows[index].Cells[3].Value.ToString();
            textBox19.Text = dataGridView4.Rows[index].Cells[4].Value.ToString();
        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView3.CurrentRow.Index;
            //x` MessageBox.Show(index.ToString());
            comboBox3.Text = dataGridView3.Rows[index].Cells[0].Value.ToString();
            textBox10.Text = dataGridView3.Rows[index].Cells[1].Value.ToString();
            textBox11.Text = dataGridView3.Rows[index].Cells[2].Value.ToString();
            textBox12.Text = dataGridView3.Rows[index].Cells[3].Value.ToString();
        }

        private void load_hoadon()
        {
            NhaCungCap_BLL ncc = new NhaCungCap_BLL();
            DataTable dt = ncc.Select_NhaCungCap();
            comboBox1.DataSource = dt;
           
            comboBox1.ValueMember = "MaNhaCungCap";
            comboBox1.DisplayMember = "TenNhaCungCap"; 
        }
        private void load_hanghoa()
        {
            NhaCungCap_BLL ncc = new NhaCungCap_BLL();
            DataTable dt = ncc.Select_NhaCungCap();
            comboBox2.DataSource = dt;

            comboBox2.ValueMember = "MaNhaCungCap";
            comboBox2.DisplayMember = "TenNhaCungCap";
        }
        private void load_ncc()
        {
            NhaCungCap_BLL ncc = new NhaCungCap_BLL();
            DataTable dt = ncc.Select_NhaCungCap();
            comboBox3.DataSource = dt;

            comboBox3.ValueMember = "MaNhaCungCap";
            
        }
        private DataTable sinhmancc()
        {
        SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-49Q2S97\SQLEXPRESS; Initial Catalog = laptrinhungdung; Integrated Security = True");
        kn.Open();
        string sql = "select top 1* from NhaCungCap  order by MaNhaCungCap desc";
        SqlCommand cm = new SqlCommand(sql, kn);/// thực thi sql
        SqlDataAdapter adapter = new SqlDataAdapter(cm);// chuyển đổi data
        DataTable dttable = new DataTable();  //table chứa dữ liệu đổ về
        adapter.Fill(dttable);
        dataGridView3.DataSource = dttable;
        kn.Close();
            return dttable;
        }
        string ma;
        private string sinhmatudong()
        {
            DataTable dt = sinhmancc();
            if (dt.Rows.Count != 0)
                {
                ma = dt.Rows[0][0].ToString();
                int length = ma.Length;
                ma = ma.Substring(3, length - 3);
                int maso;
                if (int.Parse(ma) >= 1 && int.Parse(ma) < 9)
                {
                    maso = int.Parse(ma) + 1;
                    return "NCC0" + maso.ToString();

                }
                else
                {
                    maso = int.Parse(ma) + 1;
                    return "NCC" + maso.ToString();

                }
            }
            else
            {
                return "NCC01";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}   
