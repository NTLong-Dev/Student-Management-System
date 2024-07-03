using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLSV.Profile;
using static QLSV.ProfileGV;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV
{
    public partial class qmk : Form
    {
        Du_AnEntities da = new Du_AnEntities();
        string maText = GlobalData.MaText;
        string maTextgv = GlobalData1.MaTextgv;
        public qmk()
        {
            InitializeComponent();
        }

        private void qmk_Load(object sender, EventArgs e)
        {

        }

        private void tdn_TextChanged(object sender, EventArgs e)
        {

        }

        private void mkcu_TextChanged(object sender, EventArgs e)
        {

        }

        private void mkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

                string mkc = (mkcu.Text);


                if (!string.IsNullOrEmpty(maText))
                {
                   string id = maText;
                    ChangeSV(id, mkc);
                }
                else if (!string.IsNullOrEmpty(maTextgv))
                {
                   string id = maTextgv;
                    ChangeGV(id, mkc);

                }
            
        }
        private void ChangeSV(string id, string mkc)
        {
            var sv = da.sinhviens.Find(id);
            if (sv != null)
            {
                if (mkc == sv.matkhau)
                {
                    if (!string.IsNullOrEmpty(mkc))
                    {
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
                        MessageBox.Show("Mật khẩu cũ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với ID này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ChangeGV(string id, string mkc)
        {
            var gv = da.giangviens.Find(id);
            if (gv != null)
            {
                if (mkc == gv.matkhau)
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
                        MessageBox.Show("Mật khẩu cũ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy giảng viên với ID này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tdn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
