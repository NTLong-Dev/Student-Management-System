using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class doimk : Form
    {
        Du_AnEntities da = new Du_AnEntities();
        public doimk()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void doimk_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tdn.Text))
            {
                    string id = tdn.Text;
                    string mkc = (mkcu.Text);
                if (comboBox1.SelectedItem != null)
                {       
                    string selectedOption = comboBox1.SelectedItem.ToString();
                
                    if (selectedOption == "Sinh viên")
                    {
                        ChangeSV(id, mkc);
                    }
                    else if (selectedOption == "Giảng viên")
                    {
                        ChangeGV(id, mkc);

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập Tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void ChangeSV(string id, string mkc)
        {
            var sv = da.sinhviens.Find(id);
            string patterns = "[0-9]";
            Regex regex = new Regex(patterns);
            string pattern = "[0-9a-zA-Z]";
            Regex regex1 = new Regex(pattern);
            if (sv != null)
            {
                if (mkc == sv.sdt)
                {
                    if(!string.IsNullOrEmpty(mkc)) {
                        if (!string.IsNullOrEmpty(mkm.Text) && !string.IsNullOrWhiteSpace(mkm.Text))
                        {
                            sv.matkhau = (mkm.Text);
                            da.SaveChanges();
                            this.Close();
                            MessageBox.Show("Đổi mật khẩu thành công.", "Xác thực", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("Mật khẩu mới không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    }

                }
                else if (!regex.IsMatch(mkc))
                {

                    MessageBox.Show("Số điện thoại không đúng đinh dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Số điện thoại không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!regex1.IsMatch(tdn.Text))
            {
                MessageBox.Show("Tên đăng nhập không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với ID này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ChangeGV(string id, string mkc)
        {
            string patterns = "[0-9]";
            Regex regex = new Regex(patterns);
            string pattern = "[0-9a-zA-Z]";
            Regex regex1 = new Regex(pattern);
            var gv = da.giangviens.Find(id);
            if (gv != null)
            {
                if (mkc == gv.sdt)
                {
                    if (!string.IsNullOrEmpty(mkc))
                    {
                        if (!string.IsNullOrEmpty(mkm.Text) && !string.IsNullOrWhiteSpace(mkm.Text))
                        {
                            gv.matkhau = (mkm.Text);
                            da.SaveChanges();
                            this.Close();
                            MessageBox.Show("Đổi mật khẩu thành công.", "Xác thực", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                      
                        else
                        {
                            MessageBox.Show("Mật khẩu mới không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                else if (!regex.IsMatch(mkc))
                {

                    MessageBox.Show("Số điện thoại không đúng đinh dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Số điện thoại không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!regex1.IsMatch(tdn.Text))
            {
                MessageBox.Show("Tên đăng nhập không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Không tìm thấy giảng viên với ID này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void mkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
