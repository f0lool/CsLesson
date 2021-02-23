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
    public partial class Form1 : Form
    {   
        TrueFalse _dataBase;

        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                _dataBase = new TrueFalse(sfd.FileName);
                _dataBase.Add("123", true);
                _dataBase.Save();
                nudNumber.Maximum = 1;
                nudNumber.Minimum = 1;
                nudNumber.Value = 1;
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
                tboxQuestion.Text = _dataBase[(int)nudNumber.Value - 1].Text;
                cboxTrue.Checked = _dataBase[(int)nudNumber.Value - 1].TrueFalse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(_dataBase == null)
            {
                MessageBox.Show("Создайте новую базу");
                return;
            }
            _dataBase.Add((_dataBase.Count + 1).ToString(), true);
            nudNumber.Maximum = _dataBase.Count;
            nudNumber.Value = _dataBase.Count;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || _dataBase == null) return;

            DialogResult result = MessageBox.Show("Вы точно хотите удалить вопрос?", "Предупреждение", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                _dataBase.Remove((int)nudNumber.Value);
                nudNumber.Maximum--;
                if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (_dataBase != null) _dataBase.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _dataBase = new TrueFalse(ofd.FileName);
                _dataBase.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = _dataBase.Count;
                nudNumber.Value = 1;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _dataBase[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
            _dataBase[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Червов Алексей\n" +
                "Версия: 1.0\n", "О программе");
        }
    }
}
