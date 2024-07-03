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
        using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

        namespace QLSV
        {
            public partial class themlop : Form
            {
                Du_AnEntities da = new Du_AnEntities();
        public themlop()
                {
                    InitializeComponent();
                }

                private void themlop_Load(object sender, EventArgs e)
                {
           
            this.khoaTableAdapter.Fill(this.du_AnDataSet3.khoa);
                }

                private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                if (da.lops.Any(k => k.tenlop == ten.Text))
                {
                    MessageBox.Show("Tên lớp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lop lops = new lop()
                    {
                        malop = ma.Text,
                        tenlop = ten.Text,
                        tenkhoa = tenkh.Text,
                        khoahoc = kh.Text,
                    };
                    da.lops.Add(lops);
                    da.SaveChanges();
                    (Application.OpenForms["lopvakhoa"] as lopvakhoa)?.loaddata();
                    this.Close();
                }
            }
                }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tenkh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
        }
