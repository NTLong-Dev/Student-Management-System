using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class suahp : Form
    {
        Du_AnEntities du_An = new Du_AnEntities();
        public string mahp { get; set; }
        public string tenhp { get; set; }
        public string namhoc { get; set; }
        public int sotinchi { get; set; }

        public suahp(String Ma , String Ten, String Nam , int tinchi)
        {
           
            InitializeComponent();
            this.mahp = Ma;
            this.tenhp = Ten;
            this.namhoc = Nam;
            this.sotinchi = tinchi;
            ma.Text = mahp;
            ten.Text = tenhp;
            nh.Text = namhoc;
            tc.Text = sotinchi.ToString();
        }

        private void suahp_Load(object sender, EventArgs e)
        {
            nh.FlatStyle = FlatStyle.Flat;
            nh.BackColor = Color.White;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn sửa", "Sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int tinc = Convert.ToInt32(tc.Text);
                string id = ma.Text;
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
                    if (du_An.hoc_phan.Any(k => k.tenhp == ten.Text))
                    {
                        MessageBox.Show("Tên học phần đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        hoc_phan hp = du_An.hoc_phan.Find(id);

                        hp.mahp = ma.Text;
                        hp.tenhp = ten.Text;
                        hp.namhoc = nh.Text;
                        hp.sotinchi = tinc;


                        // sửa 
                        du_An.SaveChanges();
                        (Application.OpenForms["hocphan"] as hocphan)?.loadData();
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
    }
}
