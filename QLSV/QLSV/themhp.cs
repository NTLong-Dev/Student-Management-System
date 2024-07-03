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
  
    public partial class themhp : Form
    {
        Du_AnEntities Du_An = new Du_AnEntities();
        public themhp()
        {
            InitializeComponent();
        }

        private void themhp_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string pattern = "[0-9a-zA-Z]";
            string patterns = "[0-9]";
            string patterns1 = "[a-zA-Z]";
            Regex regex = new Regex(pattern);
            Regex regex1 = new Regex(patterns);
            Regex regex2 = new Regex(patterns1);
            if (!regex.IsMatch(ma.Text))
            {
                MessageBox.Show("Mã không đúng đinh dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!regex2.IsMatch(ten.Text))
            {
                MessageBox.Show("Tên không đúng đinh dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!regex1.IsMatch(tc.Text))
            {
                MessageBox.Show("Số tín chỉ không đúng đinh dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Du_An.hoc_phan.Any(k => k.tenhp == ten.Text))
                {
                    MessageBox.Show("Tên học phần đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    hoc_phan hp = new hoc_phan()
                    {
                        mahp = ma.Text,
                        tenhp = ten.Text,
                        namhoc = nam.Text,
                        sotinchi = Convert.ToInt32(tc.Text)
                    };
                    Du_An.hoc_phan.Add(hp);
                    Du_An.SaveChanges();
                    (Application.OpenForms["hocphan"] as hocphan)?.loadData();
                    this.Close();
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
