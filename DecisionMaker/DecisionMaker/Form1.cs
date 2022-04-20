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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Decision maker";
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
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
            
            int karar = random.Next(1,3);

            if (karar == 1)
            {
                label2.Text = textBox1.Text;
            }
            else
            {
                label2.Text = textBox2.Text;
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisEkranı girisEkranısec = new GirisEkranı();
            girisEkranısec.Show();
            this.Hide();
        }
    }
}
