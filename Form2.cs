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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void buttoncompare_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (txtS1.Text == txtS2.Text)
                listBox1.Items.Add("Hai chuỗi giống nhau");
            else
                listBox1.Items.Add("Hai chuỗi không giống nhau");
        }

        private void buttoncompare2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            if (txtS1.Text.ToLower() == txtS2.Text.ToLower())
                listBox1.Items.Add("Hai chuỗi giống nhau");
            
            else
                listBox1.Items.Add("Hai chuỗi không giống nhau");
        }

        private void buttonconcat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtS1.Text + txtS2.Text);
        }

        private void buttonstop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            txtS1.Text =  "";
            txtS2.Text = "";
            listBox1.Items.Clear ();
            txtS1.Focus();
        }

        private void buttonindexof_Click(object sender, EventArgs e)
        {
            string S1, S2, kq;
            S1 = txtS1.Text;
            S2 = txtS2.Text;
            int vt;
            vt = S1.IndexOf(S2);
            if (vt > 0)
            {   
                kq = S1.Replace(S2, "CHỖ NÀY");
                
            }
            else
                kq = "Không chứa";
            listBox1.Items.Add(kq);
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            string S1, S2, first, mid, last, kq;
            S1 = txtS1.Text;
            S2 = txtS2.Text;
            first = S1.Substring(0, 1);
            last = S1.Substring(S1.Length - 1);
            if (S1.Length == 0)
            {
                listBox1.Items.Add("Nhập lại");
                return;
            }
            if (S1.Length == 1)
            {
                first = "";
                mid = S1;
                last = "";
            }
            else
            {
                mid = S1.Substring(1,S1.Length - 2);
            }
            kq = first + S2 + mid + S2 + last;
            listBox1.Items.Clear();
            listBox1.Items.Add(kq);
        }
    }
}
