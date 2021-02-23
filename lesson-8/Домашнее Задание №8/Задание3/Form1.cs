using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Задание3
{
    public partial class Form1 : Form
    {
        private List<Student> _dataBase;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            SaveFileDialog sfd = new SaveFileDialog();
            OpenFileDialog ofd = new OpenFileDialog();
            _dataBase = new List<Student>();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);

                while (!sr.EndOfStream)
                {
                    try
                    {
                        string[] s = sr.ReadLine().Split(';');
                        Student student = new Student();

                        student.Name = s[0];
                        student.Surname = s[1];
                        student.Age = int.Parse(s[5]);
                        student.Course = int.Parse(s[6]);

                        _dataBase.Add(student);

                      
                    }
                    catch
                    {
                    }
                }
                sr.Close();
            }


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                xmlSerializer.Serialize(stream, _dataBase);

                stream.Close();
            }
           
           
        }
    }
}
