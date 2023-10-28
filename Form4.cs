using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_về_nhà_buổi_3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Init();
        }
        Object A;
        public void Init()
        {
            A = new Object();
        }

        public class Object
        {
            private string _ho;
            private string _holot;
            private string _ten;
            public string Ho
            {
                get { return _ho; }
                set { _ho = value; }
            }
            public string Holot
            {
                get { return _holot; }
                set { _holot = value; }
            }
            public string Ten
            {
                get { return _ten; }
                set { _ten = value; }
            }
            public Object()
            {
                Ho = "";
                Holot = "";
                Ten = "";
            }
            public Object(string ho_init, string holot_init, string ten_init)
            {
                Ho = ho_init;
                Holot = holot_init;
                Ten = ten_init;
            }
        }
        void Gan(string hovaten)
        {
            string[] h_t = hovaten.Split(' ');
            A.Ho = h_t[0];
            A.Holot = hovaten.Substring(h_t[0].Length, hovaten.Length - h_t[0].Length - h_t[h_t.Length - 1].Length).Replace(" ", "");
            A.Ten = h_t[h_t.Length - 1];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonin_Click(object sender, EventArgs e)
        {
            Gan(txtboxhoten.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add("Chương trình xử lý họ và tên của bạn: " + A.Ho + " " + A.Holot + " " + A.Ten);
        }

        private void buttonholot_Click_1(object sender, EventArgs e)
        {
            Gan(txtboxhoten.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add("Họ lót là: " + A.Holot);
        }

        private void buttonten_Click_1(object sender, EventArgs e)
        {
            Gan(txtboxhoten.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add("Tên là: " + A.Ten);
        }

        private void buttondemtu_Click_1(object sender, EventArgs e)
        {
            Gan(txtboxhoten.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add("Số từ là: " + (A.Ho.Count() + A.Holot.Count() + A.Ten.Count()));
        }

        private void buttonhoa_Click(object sender, EventArgs e)
        {
            Gan(txtboxhoten.Text);

            string kqtu;
            kqtu = A.Ho.ToString().ToUpper().Substring(0, 1) + A.Ho.Substring(1) + " " +
                   A.Holot.ToString().ToUpper().Substring(0, 1) + A.Holot.Substring(1) + " " +
                   A.Ten.ToString().ToUpper().Substring(0, 1) + A.Ten.Substring(1);
            listBox1.Items.Clear();
            listBox1.Items.Add(kqtu);
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            txtboxhoten.Text = " ";
            listBox1.Items.Clear();
            txtboxhoten.Focus();
        }
    }
}
