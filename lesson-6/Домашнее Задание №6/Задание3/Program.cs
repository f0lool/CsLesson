#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
3. Переделать программу «Пример использования коллекций» для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента;
д) разработать единый метод подсчета количества студентов по различным параметрам
выбора с помощью делегата и методов предикатов.
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
#endregion

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfBachelors = 0;
            int numOfMasters = 0;
            int numOfFiveSixCourse = 0;
            ArrayList list = new ArrayList();
            List<Student> students = new List<Student>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader(@"C:\Users\user\Desktop\students.csv");
            int[] courses = new int[] { 0, 0, 0, 0, 0, 0 };

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(s[1] + " " + s[0]);
                    Student student = new Student();

                    student.firstName = s[0];
                    student.secondName = s[1];
                    student.age = int.Parse(s[5]);
                    student.course = int.Parse(s[6]);

                    students.Add(student);

                    if (int.Parse(s[6]) < 5) numOfBachelors++; else numOfMasters++;
                    if (int.Parse(s[6]) == 5 || int.Parse(s[6]) == 6) numOfFiveSixCourse++;
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) < 20) courses[int.Parse(s[6]) - 1]++;
                }
                catch
                {
                }
            }
            sr.Close();
            students = students.OrderBy(a => a.age).ThenBy(a => a.age).ToList();
            Console.WriteLine("Всего студентов:{0}", list.Count);
            Console.WriteLine("Магистров:{0}", numOfMasters);
            Console.WriteLine("Бакалавров:{0}", numOfBachelors);
            Console.WriteLine($"Студентов на 5 или 6 курсах: {numOfFiveSixCourse}");

            for (int i = 0; i < 6; i++)
                Console.WriteLine($"Количество учащихся от 18 до 20 лет на {i + 1} курсе равно {courses[i]}");

            foreach (var v in students) Console.WriteLine(v.course + " " + v.age);
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }

    class Student
    {
        public string firstName;
        public string secondName;
        public int age;
        public int course;
    }
}
