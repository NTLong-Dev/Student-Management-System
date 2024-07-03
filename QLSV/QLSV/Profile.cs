using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Profile : Form
    {
        Du_AnEntities du_an = new Du_AnEntities();
        public string Ma_SV { get; set; }
        public Profile(String maSV)
        {
            InitializeComponent();
            this.Ma_SV = maSV;
            ma.Text = Ma_SV;
            GlobalData.MaText = ma.Text;
        }
       

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }
        void loadData()
        {
            var image = from sv in du_an.sinhviens where sv.masv == ma.Text
                         select sv.anh;
            byte[] img = image.FirstOrDefault(); 
            pis.Image = ByteArrayToImage(img);
            var tens = from sv in du_an.sinhviens
                        where sv.masv == ma.Text
                        select sv.tensv;
            String name = tens.FirstOrDefault();
            ten.Text = name;
            var goit = from sv in du_an.sinhviens
                       where sv.masv == ma.Text
                       select sv.gioitinh;
            String gend = goit.FirstOrDefault();
            gt.Text = gend;
            var so = from sv in du_an.sinhviens
                     where sv.masv == ma.Text
                     select sv.sdt;
            String tele = so.FirstOrDefault();
            sdt.Text = tele;
                var ngays = from sv in du_an.sinhviens
                         where sv.masv == ma.Text
                         select sv.ngaysinh;
            DateTime? dateNullable = ngays.FirstOrDefault();
            string date = dateNullable?.ToString("dd-MM-yyyy");
            ngay.Text = date;

            var dc = from sv in du_an.sinhviens
                       where sv.masv == ma.Text
                     select sv.diachi;
            String area = dc.FirstOrDefault();
            diachi.Text = area;
            var tl = from sv in du_an.sinhviens
                     where sv.masv == ma.Text
                     select sv.tenlop;
            String tenlp = tl.FirstOrDefault();
            tenlops.Text = tenlp;
            var tk = from sv in du_an.sinhviens
                     where sv.masv == ma.Text
                     select sv.tenkhoa;
            String tenk = tk.FirstOrDefault();
            tenkhoas.Text = tenk;

        }
        private void Profile_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public static class GlobalData
        {
            public static string MaText;
        }

        private void pis_Click(object sender, EventArgs e)
        {

        }
    }

}
