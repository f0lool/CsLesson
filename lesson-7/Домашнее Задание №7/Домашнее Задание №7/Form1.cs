using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Домашнее_Задание__7
{
    public partial class Form1 : Form
    {
        public string Last = "";

        public Form1()
        {
            InitializeComponent();

            Random random = new Random();

            btnClick1.Text = "+1";
            btnClick2.Text = "*2";
            btnClick3.Text = "Reset";
            label1.Text = "0";
            btnExit.Text = "Отменить";

            label2.Text = "Количество ходов: ";
            label3.Text = "0";



            MessageBox.Show("Вы должны получить число: " + random.Next(1, 1000000).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) * 2).ToString();
            label3.Text = (int.Parse(label3.Text) + 1).ToString();
            Last = "*2";
        }

        private void btnClick1_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
            label3.Text = (int.Parse(label3.Text) + 1).ToString();
            Last = "+1";
        }

        private void btnClick3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label3.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Last == "*2")
            {
                label1.Text = (int.Parse(label1.Text) / 2).ToString();
                Last = "";
            }
            if (Last == "+1")
            {
                label1.Text = (int.Parse(label1.Text) - 1).ToString();
                Last = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

    }
}
