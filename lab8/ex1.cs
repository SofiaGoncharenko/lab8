//приклад 1
using System;

namespace lab8
{
    class ex1
    {
        delegate void GetMessage(); //оголошення делегата
        static void Main(string[] args)
        {
            GetMessage del; // створюємо об'єкт типу делегат

            if(DateTime.Now.Hour < 12)
            {
                del = GoodMorning;
            }
            else
            {
                del = GoodEvening;
            }
            del.Invoke(); //викликаємо метод
            Console.ReadKey();
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning!");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening!");
        }
    }
}
