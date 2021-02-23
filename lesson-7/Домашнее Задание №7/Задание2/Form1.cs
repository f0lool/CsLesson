using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание2
{
    public partial class Form1 : Form
    {
        private int randomNumber = 0;

        public Form1()
        {
            InitializeComponent();

            Random random = new Random();

            randomNumber = random.Next(1, 100);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            if(int.Parse(textBox1.Text) == randomNumber)
            {
                lbCount.Text = (int.Parse(lbCount.Text) + 1).ToString();
                MessageBox.Show("Вы победили за " + lbCount.Text + " попыток");
                randomNumber = random.Next(1, 100);
                lbCount.Text = "0";
            } else
            {
                lbCount.Text = (int.Parse(lbCount.Text) + 1).ToString();
            }
        }
    }
}
