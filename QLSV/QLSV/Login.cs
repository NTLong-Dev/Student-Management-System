using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Login : Form
    {
        Du_AnEntities du_an = new Du_AnEntities();

        String user = "admin";
        string password = "123";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            string tk = taikhoan.Text;
            string mk = (matkhau.Text);
            var ten = (from sv in du_an.sinhviens
                       where sv.masv == tk && sv.matkhau == mk
                       select sv.tensv).FirstOrDefault();
            var tgv = (from gv in du_an.giangviens
                      where gv.magv == tk && gv.matkhau == mk
                      select gv.tengv).FirstOrDefault();
            if (tk == "" && mk == "")
            {
                
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống");
            }
            else if (mk == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
            }
            else if (tk == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống");
            }
            else
            {
                if (tk == user && mk == password)
                {


                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
                else if (!string.IsNullOrEmpty(ten))
                {
                    String memory = taikhoan.Text.Trim();

                    Form2 f2 = new Form2(memory);
                    f2.Show();
                    this.Hide();
                }
                else if (!string.IsNullOrEmpty(tgv))
                {
                    String memorys = taikhoan.Text.Trim();

                    Form3 f3 = new Form3(memorys);
                    f3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
           
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void matkhau_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            doimk mk = new doimk();
            mk.Show();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if(matkhau.PasswordChar == '*')
            {
                eye.BringToFront();
                matkhau.PasswordChar = '\0';
            }
        }

        private void eye_Click(object sender, EventArgs e)
        {
            if (matkhau.PasswordChar == '\0')
            {
                hide.BringToFront();
                matkhau.PasswordChar = '*';
            }
        }
    }
}
