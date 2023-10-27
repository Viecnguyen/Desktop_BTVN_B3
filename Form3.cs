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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int uscln;
        
        private void buttonkq_Click(object sender, EventArgs e)
        {
            int a = int.Parse( txtboxa.Text); 
            int b = int.Parse(txtboxb.Text);
            
            if (radioButtonuscln.Checked)
            { 
                for (int i = 1; i <= a; i++)
                { 
                    if (a % i ==  0 && b % i == 0)
                    uscln = i;
                }
                listBox1.Items.Clear();
                listBox1.Items.Add(uscln);
            }
            if (radioButtonusc.Checked)
            {
                listBox1.Items.Clear();
                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0 && b % i == 0)
                        listBox1.Items.Add(i);
                }

            }
        }
    }
}
