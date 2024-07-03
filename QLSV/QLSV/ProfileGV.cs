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
    public partial class ProfileGV : Form
    {
        public string magv { get; set; }
        Du_AnEntities du_an = new Du_AnEntities();
        public ProfileGV(String Magv)
        {
            InitializeComponent();
            this.magv = Magv;
            ma1.Text = Magv;
            GlobalData1.MaTextgv = ma1.Text;
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
            var image = from gv in du_an.giangviens
                        where gv.magv == ma1.Text
                        select gv.anh;
            byte[] img = image.FirstOrDefault();
            pis.Image = ByteArrayToImage(img);
            var tens = from gv in du_an.giangviens
                       where gv.magv == ma1.Text
                       select gv.tengv;
            String name = tens.FirstOrDefault();
            ten.Text = name;
            var so = from gv in du_an.giangviens
                     where gv.magv == ma1.Text
                     select gv.sdt;
            String tele = so.FirstOrDefault();
            sdt.Text = tele;
            var ngays = from gv in du_an.giangviens
                        where gv.magv == ma1.Text
                        select gv.ngaysinh;
            DateTime? dateNullable = ngays.FirstOrDefault();
            string date = dateNullable?.ToString("dd-MM-yyyy");
            ngay.Text = date;

            var dc = from gv in du_an.giangviens
                     where gv.magv == ma1.Text
                     select gv.diachi;
            String area = dc.FirstOrDefault();
            diachi.Text = area;
            var md = from gv in du_an.giangviens
                     where gv.magv == ma1.Text
                     select gv.monday;
            String mondays = md.FirstOrDefault();
            mond.Text = mondays;
            var tk = from gv in du_an.giangviens
                     where gv.magv == ma1.Text
                     select gv.tenkhoa;
            String tenk = tk.FirstOrDefault();
            tenkhoas.Text = tenk;

        }
        private void ProfileGV_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public static class GlobalData1
        {
            public static string MaTextgv;
        }
    }
}
