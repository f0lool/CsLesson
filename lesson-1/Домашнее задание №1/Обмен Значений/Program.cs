#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
4. Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region При помощи третьей переменной
            var a = 5;
            var b = 7;
            var t = a;
            a = b;
            b = t;
            #endregion

            #region Без использования третьей переменной
            a = 5;
            b = 7;
            b = a + b;
            a = b - a;
            b = a - b;
            #endregion

            Console.ReadLine();
        }
    }
}
