using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLSV
{
    public partial class diemSV : Form
    {
        Du_AnEntities du_an = new Du_AnEntities();
        public diemSV()
        {
            InitializeComponent();
        }
        public void loaddata() {
            var result = from c in du_an.diems select new { c.id, c.masv, c.tensv, c.monhoc, c.lop, c.diem1, c.diem2, c.diem3, c.diemtb, c.ketqua };
            grv.DataSource = result.ToList();
            var result21 = du_an.diems.Where(s => s.ketqua == "A" || s.ketqua == "B+").Count();
            int count1 = result21;
            gioi.Text = count1.ToString();
            var result22 = du_an.diems.Where(s => s.ketqua == "B" || s.ketqua == "C+").Count();
            int count2 = result22;
            kha.Text = count2.ToString();
            var result23 = du_an.diems.Where(s => s.ketqua == "C" || s.ketqua == "D+").Count();
            int count3 = result23;
            trb.Text = count3.ToString();
            var result24 = du_an.diems.Where(s => s.ketqua == "D" || s.ketqua == "F(Học lại)").Count();
            int count4 = result24;
            yeu.Text = count4.ToString();
            var result3 = (from sv in du_an.diems
                           select sv.ketqua).Distinct();

            foreach (var kq in result3)
            {
                cb.Items.Add(kq);
            }


        }
        private void diemSV_Load(object sender, EventArgs e)
        {
            hp.SelectedIndexChanged += hp_SelectedIndexChanged;
            var hpList = du_an.hoc_phan.Select(sv => sv.tenhp).ToList();

            foreach (var masvValue in hpList)
            {
                hp.Items.Add(masvValue);
            }
            lopss.SelectedIndexChanged += lopss_SelectedIndexChanged;
            var lopssList = du_an.lops.Select(sv => sv.tenlop).ToList();

            foreach (var Value in lopssList)
            {
                lopss.Items.Add(Value);
            }

            loaddata();
        }
        private void hp_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedhp = hp.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedhp))
            {
                var selectedSinhVien = du_an.hoc_phan.FirstOrDefault(sv => sv.tenhp == selectedhp);

                if (selectedSinhVien != null)
                {
                    var results = from c in du_an.diems where c.monhoc == selectedhp  select new { c.id, c.masv, c.tensv, c.monhoc, c.lop, c.diem1, c.diem2, c.diem3, c.diemtb, c.ketqua };
                    grv.DataSource = results.ToList();
                }
                else
                {
                    
                }
            }

        }
        private void lopss_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedlop = lopss.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedlop))
            {
                var selectedSinhVien = du_an.lops.FirstOrDefault(sv => sv.tenlop == selectedlop);

                if (selectedSinhVien != null)
                {
                    var results = from c in du_an.diems where c.lop == selectedlop select new { c.id, c.masv, c.tensv, c.monhoc, c.lop, c.diem1, c.diem2, c.diem3, c.diemtb, c.ketqua };
                    grv.DataSource = results.ToList();
                }
                else
                {

                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            themdiem td = new themdiem();
            td.Show();
        }

        private void grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grv.Columns[e.ColumnIndex].Name == "sua")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = grv.Rows[rowIndex];
                string ma1 = selectedRow.Cells["id"].Value.ToString();
                int idInt4 = Convert.ToInt32(ma1);
                string masv = selectedRow.Cells["masv"].Value.ToString();
                string tensv = selectedRow.Cells["tensv"].Value.ToString();
                string monhoc = selectedRow.Cells["monhoc"].Value.ToString();
                string lop = selectedRow.Cells["lop"].Value.ToString();
                string diem1 = selectedRow.Cells["diem1"].Value.ToString();
                string diem2 = selectedRow.Cells["diem2"].Value.ToString();
                string diem3 = selectedRow.Cells["diem3"].Value.ToString();
                string diemtb = selectedRow.Cells["diemtb"].Value.ToString();
                double p1 = Convert.ToDouble(diem1);
                double p2 = Convert.ToDouble(diem2);
                double p3 = Convert.ToDouble(diem3);
                double p4 = Convert.ToDouble(diemtb);
                string ketqua = selectedRow.Cells["ketqua"].Value.ToString();

                suadiem ei = new suadiem(idInt4, masv, tensv, monhoc, lop,p1, p2, p3, p4, ketqua);
                ei.Show();



            }
            if (grv.Columns[e.ColumnIndex].Name == "xoa")
            {
                DialogResult result = MessageBox.Show("Bạn muốn Xoá", "Xoá", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = grv.Rows[rowIndex];
                    string ma = selectedRow.Cells["id"].Value.ToString();
                    int idInt = Convert.ToInt32(ma);
                    var ToDelete = du_an.diems.Where(d => d.id == idInt).FirstOrDefault();
                    du_an.diems.Remove(ToDelete);
                    du_an.SaveChanges();
                    loaddata();
                }
                else { }
            }
            if (grv.Columns[e.ColumnIndex].Name == "ct")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = grv.Rows[rowIndex];
                string diem1 = selectedRow.Cells["diem1"].Value.ToString();
                string diem2 = selectedRow.Cells["diem2"].Value.ToString();
                string diem3 = selectedRow.Cells["diem3"].Value.ToString();
                double p1 = Convert.ToDouble(diem1);
                double p2 = Convert.ToDouble(diem2);
                double p3 = Convert.ToDouble(diem3);

                chitietdiem ea = new chitietdiem(p1, p2, p3);
                ea.Show();



            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            String timk = tim.Text;
            var results32 = (from c in du_an.diems
                             where c.tensv == timk
                             select new { c.id, c.masv, c.tensv, c.monhoc, c.lop, c.diem1, c.diem2, c.diem3, c.diemtb, c.ketqua }).ToList();

            grv.DataSource = results32;
        }

        private void tk_Click(object sender, EventArgs e)
        {
            List<object> resultsList = new List<object>();
        
                var resultsy = (from sv in du_an.diems
                               where sv.ketqua == cb.Text
                               select new {sv.tensv, sv.diemtb, sv.ketqua }).ToList();
                resultsList.AddRange(resultsy);
            

            ttg.DataSource = resultsList;
            ttg.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cb.Text = "";
            ttg.Visible = false;
        }
    }
}
