﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            btnPlay.Text = "Играть";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            Hide();
        }
    }
}
