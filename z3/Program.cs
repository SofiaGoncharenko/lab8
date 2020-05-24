/*Оголосити тип делегату, що посилається на метод. Вимоги до сигнатури методу наступні:
 метод отримує вхідним параметром змінну типу double;
 метод повертає значення типу double, яке є результатом обчислення згідно з умовою задачі.
Реалізувати виклик трьох методів з допомогою одного делегату, які отримують радіус кола R в якості
вхідного параметру і обчислюють:
довжину кола за формулою D = 2πR;
 площу круга за формулою S = πR2;
 об‘єм кулі. Формула V = 4/3πR3.
Методи повинні бути представлені в окремому класі як нестатичні.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Program
    {
        public delegate double Circle(double r);
       
        static void Main(string[] args)
        {
            try
            {
                Methods meth = new Methods();

                double R;
                Console.Write("Enter R = ");

                R = Double.Parse(Console.ReadLine());
                if (R > 0)
                {
                    Circle deligate = meth.Square;
                    Console.WriteLine("Square is " + deligate(R));
                    deligate = meth.Perimetr;
                    Console.WriteLine("Perimetr is " + deligate(R));
                    deligate = meth.Volume;
                    Console.WriteLine("Volume is " + deligate(R));

                }
                else
                {
                    Console.WriteLine("Invalid R");
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
