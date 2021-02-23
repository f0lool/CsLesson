#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
2. Разработать класс Message, содержащий следующие статические методы для обработки
текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
Продемонстрируйте работу программы на текстовом файле с вашей программой.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
#endregion

namespace Задание2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите путь к файлу: ");

            string filepath = Console.ReadLine();

            StreamReader streamReader = new StreamReader(filepath);

            string text = "";

            while (!streamReader.EndOfStream)
                text = text + streamReader.ReadLine() + " ";

            Console.Write("Что вы хотите сделать с вашим сообщение:\n" +
                "1.Вывести только те слова которые содержат не более n букв\n" +
                "2.Удалить из сообщения все слова, которые заканчиваются на заданный символ.\n" +
                "3.Найти самое длинное слово сообщения\n" +
                "4.Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.\n" +
                "5.Вывести на экран\n" +
                "6.Закончить\n");

            int switchNumber = default;
            while (switchNumber != 6)
            {
                switchNumber = int.Parse(Console.ReadLine());

                switch (switchNumber)
                {
                    case 1:
                        Console.Write("Введите ограничение на длину слова: ");
                        int count = int.Parse(Console.ReadLine());
                        Message.PrintString(text, count);
                        break;
                    case 2:
                        Console.Write("Введите символ: ");
                        char letter = char.Parse(Console.ReadLine());
                        text = Message.Delete(text, letter);
                        break;
                    case 3:
                        Console.Write($"Самое длинное слово {Message.LongWord(text)}");
                        break;
                    case 4:
                        Console.Write("Введите количество самых длинных слов: ");
                        count = int.Parse(Console.ReadLine());
                        Console.Write(Message.CreateLongText(text, count));
                        break;
                    case 5:
                        Console.Write(text + "\n");
                        break;
                    case 6:
                        break;
                }

            }
            Console.WriteLine(Message.CreateLongText(text, 3));

            streamReader.Close();

            Console.ReadLine();
        }

    }
    class Message
    {
        public static void PrintString(string text, int countLetter)
        {
            List<string> words = CreateListString(text);

            foreach (string word in words)
                if (word.Length <= countLetter)
                    Console.WriteLine(word);
        }

        public static string Delete(string text, char letter)
        {
            string text1 = "";

            List<string> words = CreateListString(text);

            for (int i = 0; i < words.Count; i++)
                if (words[i].Length != 0)
                    if (words[i][words[i].Length - 1] == letter)
                        words.RemoveAt(i);

            for (int i = 0; i < words.Count; i++)
                text1 = text1 + words[i] + " ";

            return text1;
        }

        public static List<string> LongWords(string text)
        {
            List<string> words = CreateListString(text);

            words.Sort((a, b) => b.Length.CompareTo(a.Length));

            return words;
        }

        public static string LongWord(string text)
        {
            string longText;

            List<string> words = LongWords(text);

            longText = words[0];

            return longText;
        }

        public static StringBuilder CreateLongText(string text, int count)
        {
            List<string> words = LongWords(text);

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < count; i++)
                stringBuilder.Append(words[i] + " ");

            return stringBuilder;
        }

        public static List<string> CreateListString(string text)
        {
            for (int i = 0; i < text.Length; i++)
                if (char.IsPunctuation(text, i))
                    text = text.Remove(i, 1);

            List<string> words = new List<string>(text.Split(' '));

            return words;
        }

    }
}
