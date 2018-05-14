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
    public partial class Form2 : Form
    {
        TaiKhoan_BLL tkbll = new TaiKhoan_BLL();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() != Program.MatKhau.Trim())
            {
                MessageBox.Show("Nhập Lại Mật Khẩu không đúng, Hãy Nhập Lại !", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox2.Text.Trim() == textBox3.Text.Trim())
                {
                    tkbll.Update_TaiKhoan(Program.TaiKhoan, textBox2.Text.Trim());
                    MessageBox.Show("Đổi Mật Khẩu Thành Công");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nhập Lại Mật Khẩu không đúng, Hãy Nhập Lại !", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}