using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        double alpha;
        
        private void button1_Click(object sender, EventArgs e)
        {
            c();
            if (textBox1.Text!="")
            {
                alpha = rnd.NextDouble();
                if (alpha >= 0.5)
                    yes();
                else
                    no();
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void c()
        {
            label2.Visible = false;
            answer.Visible = false;
        }

        private void no()
        {
            answer.Text = "NO";
            answer.BackColor = Color.Red;
            answer.Visible = true;
        }

        private void yes()
        {
            answer.Text = "YES";
            answer.BackColor = Color.Green;
            answer.Visible = true;
        }
    }
}
