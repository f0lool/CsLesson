using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Домашнее_Задание__8
{
    public partial class FormPlay : Form
    {
        TrueFalse _dataBase;
        public bool answerCheck;

        public FormPlay()
        {
            InitializeComponent();
        }

        private void FormPlay_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _dataBase = new TrueFalse(ofd.FileName);
                _dataBase.Load();
            }
            int firstQuestion = random.Next(0, _dataBase.Count);
            lbQuestion.Text = _dataBase[firstQuestion].Text;
            answerCheck = _dataBase[firstQuestion].TrueFalse;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int nextQuestion = random.Next(0, _dataBase.Count);

            if(cboxTrue.Checked == answerCheck)
            {
                lbCount.Text = (int.Parse(lbCount.Text) + 1).ToString();
                lbQuestion.Text = _dataBase[nextQuestion].Text;
                answerCheck = _dataBase[nextQuestion].TrueFalse;
            } else
            {
                lbQuestion.Text = _dataBase[nextQuestion].Text;
                answerCheck = _dataBase[nextQuestion].TrueFalse;
            }
        }
    }
}
