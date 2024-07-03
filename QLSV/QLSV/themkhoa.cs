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
    public partial class themkhoa : Form
    {
        Du_AnEntities Du_An = new Du_AnEntities();
        public themkhoa()
        {
            InitializeComponent();
        }

        private void themkhoa_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
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
                if (Du_An.khoas.Any(k => k.tenkhoa == ten.Text))
                {
                    MessageBox.Show("Tên khoa đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    khoa k = new khoa()
                    {
                        makhoa = ma.Text,
                        tenkhoa = ten.Text,
                    };
                    Du_An.khoas.Add(k);
                    Du_An.SaveChanges();
                    (Application.OpenForms["lopvakhoa"] as lopvakhoa)?.loaddata();
                    this.Close();
                }
            }
        
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
