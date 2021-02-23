using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание1
{
    public partial class Form2 : Form
    {
        private string _last = "";
        private int needleNumber = 0;
        public Form2()
        {
            Random random = new Random();
            InitializeComponent();
            needleNumber = random.Next(1, 10);

            MessageBox.Show("Вам нужно получить число " + needleNumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbNumber.Text = "0";
            lbCount.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbNumber.Text = (int.Parse(lbNumber.Text) * 2).ToString();
            lbCount.Text = (int.Parse(lbCount.Text) + 1).ToString();
            _last = "*2";

            if (int.Parse(lbNumber.Text) == needleNumber)
            {
                MessageBox.Show("Вы победили за " + (int.Parse(lbCount.Text)).ToString());
                lbCount.Text = "0";
                lbNumber.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNumber.Text = (int.Parse(lbNumber.Text) + 1).ToString();
            lbCount.Text = (int.Parse(lbCount.Text) + 1).ToString();
            _last = "+1";

            if (int.Parse(lbNumber.Text) == needleNumber)
            {
                MessageBox.Show("Вы победили за " + (int.Parse(lbCount.Text)).ToString() + " хода");
                lbCount.Text = "0";
                lbNumber.Text = "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_last == "*2")
            {
                lbNumber.Text = (int.Parse(lbNumber.Text) / 2).ToString();
                lbCount.Text = (int.Parse(lbCount.Text) - 1).ToString();
                _last = "";
            }
            if(_last == "+1")
            {
                lbNumber.Text = (int.Parse(lbNumber.Text) - 1).ToString();
                lbCount.Text = (int.Parse(lbCount.Text) - 1).ToString();
                _last = "";
            }
                

        }
    }
}
