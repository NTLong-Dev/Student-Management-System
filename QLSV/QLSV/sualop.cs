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
    public partial class sualop : Form
    {

        Du_AnEntities da = new Du_AnEntities();
      
        public string malop { get; set; }
        public string tenlop { get; set; }
        public string tenkhoa { get; set; }
        public string khoahoc { get; set; }
        public sualop(String Ma , String Ten , String TK, String KH)
        {
            InitializeComponent();
            this.malop = Ma;
            this.tenlop = Ten;
            this.tenkhoa = TK;
            this.khoahoc = KH;
            
            ma.Text = Ma;
            ten.Text = Ten;
            tenkh.Text = TK;
            kh.Text = KH;
           

        }
       

        private void sualop_Load(object sender, EventArgs e)
        {
            var result2 = from sv in da.khoas
                          select
                         sv.tenkhoa;
            foreach (var tenSV1 in result2)
            {
                tenkh.Items.Add(tenSV1);
            }

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
                    if (da.lops.Any(k => k.tenlop == ten.Text))
                    {
                        MessageBox.Show("Tên lớp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lop lp = da.lops.Find(id);

                        lp.malop = ma.Text;
                        lp.tenlop = ten.Text;
                        lp.tenkhoa = tenkh.Text;
                        lp.khoahoc = kh.Text;



                        da.SaveChanges();
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

        private void tenkh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
