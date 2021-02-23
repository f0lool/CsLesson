#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
1. а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия,авторские права и др.).
г) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
д) Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).

2. Используя полученные знания и класс TrueFalse, разработать игру «Верю — не верю».
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

namespace Домашнее_Задание__8
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

            

            Application.Run(new Form2());
        }
    }
    [Serializable]
    public class Question
    {
        public string Text;
        public bool TrueFalse;

        public Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
    }

    class TrueFalse
    {
        string fileName;
        List<Question> _questions;

        public string FileName
        {
            set { fileName = value; }
        }

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            _questions = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            _questions.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            if (_questions != null && index < _questions.Count && index >= 0)
                _questions.RemoveAt(index);
        }

        public Question this[int index]
        {
            get { return _questions[index]; }
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            xmlSerializer.Serialize(stream, _questions);
            stream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            _questions = xmlSerializer.Deserialize(stream) as List<Question>;
            stream.Close();
        }

        public int Count
        {
            get { return _questions.Count; }
        }
    }
}
