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
    public partial class suakhoa : Form
    {
        Du_AnEntities du_An = new Du_AnEntities();
        public string makhoa { get; set; }
        public string tenkhoa { get; set; }
        public suakhoa(String Ma, String Ten)
        {
            InitializeComponent();
            this.makhoa = Ma;
            this.tenkhoa = Ten;
            ma.Text = makhoa;
            ten.Text = tenkhoa;
          
        }

        private void ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn sửa", "Sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {


                string id = ma.Text;
                string pattern = "[0-9a-zA-Z]";
                string patterns1 = "[a-zA-Z]";
                Regex regex = new Regex(pattern);
                Regex regex1 = new Regex(patterns1);
                if (!regex.IsMatch(ma.Text))
                {
                    MessageBox.Show("Mã không đúng đinh dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!regex1.IsMatch(ten.Text))
                {
                    MessageBox.Show("Tên không đúng đinh dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (du_An.khoas.Any(k => k.tenkhoa == ten.Text))
                    {
                        MessageBox.Show("Tên khoa đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        khoa k = du_An.khoas.Find(id);
                        k.makhoa = ma.Text;
                        k.tenkhoa = ten.Text;



                        du_An.SaveChanges();
                        (Application.OpenForms["lopvakhoa"] as lopvakhoa)?.loaddata();
                        this.Close();

                    }
                }
            }
            else
            {
                this.Close();

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suakhoa_Load(object sender, EventArgs e)
        {

        }
    }
}
