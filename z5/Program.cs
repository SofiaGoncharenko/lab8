/*Оголосіть два делегати: UseOperation, GetGreeting.
Перший делегат посилається на функцію, яка в якості параметрів приймає два значення типу int і повертає
деяке ціле число.
Другий делегат посилається на метод без параметрів, який нічого не повертає.
 Створіть методи без параметрів GoodMorning, GoodDay, GoodEvening і GoodNight, при виклику яких
виводиться текст «Доброго ранку!», «Добрий день!», «Добрий вечір!» і «Доброї ночі!». Якщо відомо, що
властивість DateTime.Now.Hour повертає кількість годин поточного часу, то напишіть програму, в якій, за
допомогою делегата GetGreeting, запускається один з написаних вами методів, в залежності від поточного
значення часу.
 Створіть методи для обчислення суми, різниці, добутку, частки двох цілих чисел.
Використовуючи делегат UseOperation для виклику описаних в попередньому пункті методів, напишіть
програму, яка запитує у користувача два цілих числа і операцію, яку необхідно провести. Виводить відповідний
результат.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Program
    {
        public delegate double UseOperation(double a, double b);
        public static Dictionary<String, UseOperation> operation = new Dictionary<String, UseOperation>(4) { { "+", Operation.Plus }, { "*", Operation.Mult }, { "-", Operation.Minus }, { "/", Operation.Divide } };

        static void Main(string[] args)
        {  
            try
            {
                Greeting.Output();

                double a, b;
                

                //double a, b;
                Console.Write("Enter a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Enter b = ");
                b = double.Parse(Console.ReadLine());

                Console.Write("+  " + operation["+"](a, b));
                Console.Write("\n");
                Console.Write("-  " + operation["-"](a, b));
                Console.Write("\n");
                Console.Write("*  " + operation["*"](a, b));
                Console.Write("\n");
                Console.Write("/  " + operation["/"](a, b));

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
