#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
3. *Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Xml.Serialization;
#endregion

namespace Задание3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }


    }
    [Serializable]
    public class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public int Course;
    }


}
