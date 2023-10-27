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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonkq_Click(object sender, EventArgs e)
        {
            if (radioButtonthuong.Checked) 
               listBox1.Items.Add(txtboxhoten.Text. ToLower()); 
            if (radioButtoninhoa.Checked )
                listBox1.Items.Add(txtboxhoten.Text.ToUpper());
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtboxhoten.Text = "";
            txtboxhoten.Focus();
        }
    }
}
