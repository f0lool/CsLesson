#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
где m — масса тела в килограммах, h — рост в метрах
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Считывание данных
            Console.Write("Введите ваш рост в метрах: ");
            var Growth = double.Parse(Console.ReadLine());

            Console.Write("Введите ваш вес в килограммах: ");
            var Weigth = double.Parse(Console.ReadLine());
            #endregion

            var BMI = Weigth / (Growth * Growth);

            Console.Write("Ваш Индекс Массы Тела равен: {0:f2} кг/м^2", BMI);
            Console.ReadLine();
        }
    }
}
