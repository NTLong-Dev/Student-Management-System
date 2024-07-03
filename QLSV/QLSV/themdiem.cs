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
    public partial class themdiem : Form
    {
        Du_AnEntities du_an = new Du_AnEntities();
        public themdiem()
        {
            InitializeComponent();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void themdiem_Load(object sender, EventArgs e)
        {
            this.hoc_phanTableAdapter.Fill(this.du_AnDataSet2.hoc_phan);
            masvi.SelectedIndexChanged += masvi_SelectedIndexChanged;
            var masvList = du_an.sinhviens.Select(sv => sv.masv).ToList();

            foreach (var masvValue in masvList)
            {
                masvi.Items.Add(masvValue);
            }
        }
        private void masvi_SelectedIndexChanged(object sender, EventArgs e)
        {

            tsv.Items.Clear();
            lop.Items.Clear();
            string selectedMasv = masvi.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedMasv))
            {
                var selectedSinhVien = du_an.sinhviens.FirstOrDefault(sv => sv.masv == selectedMasv);

                if (selectedSinhVien != null)
                {
                    tsv.Items.Add(selectedSinhVien.tensv);
                    lop.Items.Add(selectedSinhVien.tenlop);
                }
                else
                {
                    tsv.Items.Add("Không tìm thấy tên sinh viên");
                }
            }

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            double p1 = Convert.ToDouble(d1.Text);
            double p2 = Convert.ToDouble(d2.Text);
            double p3 = Convert.ToDouble(d3.Text);
            double tb = Math.Round((p1 + p2 + p3) / 3.0, 1);

            string kq;


            if (tb >= 0 && tb < 4)
            {
                kq = "F(Học lại)";

            }
            else if (tb > 4 && tb < 5)
            {
                kq = "D";
            }
            else if (tb < 5.5 && tb >= 5)
            {
                kq = "D+";
            }
            else if (tb >= 5.5 && tb < 6.5)
            {
                kq = "C";
            }
            else if (tb >= 6.5 && tb < 7)
            {
                kq = "C+";
            }
            else if (tb >= 7 && tb < 8)
            {
                kq = "B";
            }
            else if (tb >= 8 && tb < 8.5)
            {
                kq = "B+";
            }
            else if (tb >= 8.5 && tb <= 10)
            {
                kq = "A";
            }
            else
            {
                kq = "Lỗi";
            }
            string pattern = "[a-zA-Z]";
            Regex regex = new Regex(pattern);
                diem d = new diem()
                {
                    id = Convert.ToInt32(id1.Text),
                    masv = masvi.Text,
                    tensv = tsv.Text,
                    monhoc = mon.Text,
                    lop = lop.Text,
                    diem1 = p1,
                    diem2 = p2,
                    diem3 = p3,
                    diemtb = tb,
                    ketqua = kq
                };
                du_an.diems.Add(d);
                du_an.SaveChanges();
                (Application.OpenForms["diemSV"] as diemSV)?.loaddata();
                this.Close();
            
        }
        

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void d1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
