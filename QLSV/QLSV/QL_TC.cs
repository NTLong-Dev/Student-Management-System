using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TC
{
    public partial class QL_TC : Form
    {
        public QL_TC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void inhoadon()
        {
            inhd.Document = document;
            inhd.ShowDialog ();
        }

        private void add_Click(object sender, EventArgs e)
        {
            inhoadon();
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string ten = "Trường Đại Học Tài Nguyên và Môi Trường Hà Nội";
            String ma = "HD20";
            String ngay = "02/04/2024 12:25 pm";
            e.Graphics.DrawString(ten.ToUpper(), new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black, new Point(50, 20));
            e.Graphics.DrawString(ma.ToUpper(), new Font("Courier New", 12, FontStyle.Bold),
             Brushes.Black, new Point(600, 20));
            e.Graphics.DrawString(ngay.ToUpper(), new Font("Courier New", 12, FontStyle.Bold),
             Brushes.Black, new Point(600, 50));
            Pen black = new Pen(Color.Black, 1);
            Point p1 = new Point(10, 100);
            Point p2 = new Point(810, 100);
            e.Graphics.DrawLine(black, p1, p2);
        }

        private void thayĐổiMậtKhâutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
