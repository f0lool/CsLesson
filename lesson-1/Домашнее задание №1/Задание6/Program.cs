#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Задание6
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello, World!!!";

            UsefulMethods UM = new UsefulMethods();
            
            UM.Print(msg, 10, 10, ConsoleColor.Green);
            UM.Pause("Pause");

        }
    }

    #region Класс с полезными методами
    public class UsefulMethods
    {
        public void Print(string msg, int x, int y, ConsoleColor foregroundcolor)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }

        public void Pause()
        {
            Console.ReadKey();
        }

        public void Pause(string msgPause)
        {
            Console.WriteLine(msgPause);
            Console.ReadKey();
        }
     #endregion
    }
}
