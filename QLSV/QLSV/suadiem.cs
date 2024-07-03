using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class suadiem : Form
    {
        Du_AnEntities du_an = new Du_AnEntities();
        public int id { get; set; }
        public string masv { get; set; }
        public string tensv { get; set; }
        public string monhoc { get; set; }
        public string lop { get; set; }
        public double diem1 { get; set; }
        public double diem2 { get; set; }
        public double diem3 { get; set; }
        public double diemtb { get; set; }
        public string ketqua { get; set; }
        public suadiem(int ma, string MASV, string Ten ,string mh , string Lop, double dt1, double dt2 , double dt3, double dtb, string kq)
        {
            InitializeComponent();
            this.id = ma;
            this.masv = MASV;
            this.tensv = Ten;
            this.monhoc = mh;
            this.lop = Lop;
            this.diem1 = dt1;
            this.diem2 = dt2;
            this.diem3 = dt3;
            this.diemtb = dtb;
            this.ketqua = ketqua;


                id1.Text = ma.ToString();
                masvi.Text = MASV;
                tsv.Text = Ten;
                mon.Text = mh;
                lops.Text = Lop;
                d1.Text = dt1.ToString();
                d2.Text = dt2.ToString();
                d3.Text = dt3.ToString();
            
        }

        private void suadiem_Load(object sender, EventArgs e)
        {
            masvi.SelectedIndexChanged += masvi_SelectedIndexChanged;
            var masvList = du_an.sinhviens.Select(sv => sv.masv).ToList();

            foreach (var masvValue in masvList)
            {
                masvi.Items.Add(masvValue);
            }
            var lopList = du_an.lops.Select(sv => sv.tenlop).ToList();

            foreach (var lopValue in lopList)
            {
                lops.Items.Add(lopValue);
            }



            var mList = du_an.hoc_phan.Select(sv => sv.tenhp).ToList();

            foreach (var mValue in mList)
            {
                mon.Items.Add(mValue);
            }
            masvi.FlatStyle = FlatStyle.Flat;
            masvi.BackColor = Color.White;
            tsv.FlatStyle = FlatStyle.Flat;
            tsv.BackColor = Color.White;
            lops.FlatStyle = FlatStyle.Flat;
            lops.BackColor = Color.White;
            mon.FlatStyle = FlatStyle.Flat;
            mon.BackColor = Color.White;
        }
        private void masvi_SelectedIndexChanged(object sender, EventArgs e)
        {

            tsv.Items.Clear();
            lops.Items.Clear();
            string selectedMasv = masvi.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedMasv))
            {
                var selectedSinhVien = du_an.sinhviens.FirstOrDefault(sv => sv.masv == selectedMasv);

                if (selectedSinhVien != null)
                {
                    tsv.Items.Add(selectedSinhVien.tensv);
                    lops.Items.Add(selectedSinhVien.tenlop);
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
            int ids = Convert.ToInt32(id1.Text);
            diem di = du_an.diems.Find(ids);
            di.masv = masvi.Text;
            di.tensv = tsv.Text;
            di.monhoc = mon.Text;
            di.lop = lops.Text;
            di.diem1 = p1;
            di.diem2 = p2;
            di.diem3 = p3;
            di.diemtb = tb;
            di.ketqua = kq;
            du_an.SaveChanges();
            (Application.OpenForms["diemSV"] as diemSV)?.loaddata();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
