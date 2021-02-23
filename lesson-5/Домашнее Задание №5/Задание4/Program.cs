#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
4. Задача ЕГЭ.
*На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не
превосходит 100, каждая из следующих N строк имеет следующий формат:
<Фамилия> <Имя> <оценки>,
где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
Пример входной строки:
Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, которая будет выводить на экран
фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в
начало программы условие и свою фамилию. Все программы сделать в одном решении. Для решения
задач используйте неизменяемые строки (string)
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

namespace Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Desktop\file.txt";
            StreamReader streamReader = new StreamReader(path);
            int count = int.Parse(streamReader.ReadLine());
            List<InfoPerson> info = new List<InfoPerson>();


            for (int i = 0; i < count; i++)
            {
                string[] temp = streamReader.ReadLine().Split(' ');

                InfoPerson person = new InfoPerson();

                person.name = temp[0];
                person.surname = temp[1];
                person.middleRating = (double.Parse(temp[2]) + double.Parse(temp[3]) + double.Parse(temp[4])) / 3;

                info.Add(person);
            }

            info.Sort((a, b) => a.middleRating.CompareTo(b.middleRating));

            for (int i = 0; i < count; i++)
            {
                if (i < 3)
                    Console.WriteLine($"{info[i].name} {info[i].surname}");
                else if (info[i].middleRating == info[0].middleRating || info[i].middleRating == info[1].middleRating || info[i].middleRating == info[2].middleRating)
                    Console.WriteLine($"{info[i].name} {info[i].surname}");
            }

            streamReader.Close();

            Console.ReadKey();
        }
    }

    struct InfoPerson
    {
        public string name;
        public string surname;
        public double middleRating;
    }
}
