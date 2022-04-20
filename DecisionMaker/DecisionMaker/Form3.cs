using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionMaker_Myself_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisEkranı girisEkranısec = new GirisEkranı();
            girisEkranısec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = " ";



            progressBar1.Value = 0;
            progressBar1.Step = 1;
            for (int i = 0; i <= 100; i++)
            {
                label3.Text = "%" + i.ToString();
                progressBar1.PerformStep();
                Application.DoEvents();
                System.Threading.Thread.Sleep(12);
            }

            Random random = new Random();

            int karar = random.Next(1, 5);

            if (karar == 1)
            {
                label2.Text = textBox1.Text;
            }
            else if (karar == 2)
            {
                label2.Text = textBox2.Text;
            }
            else if (karar == 3)
            {
                label2.Text = textBox3.Text;
            }
            else
            {
                label2.Text = textBox4.Text;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Decision maker";
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
        }
    }
}
