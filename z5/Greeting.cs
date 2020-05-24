using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Greeting
    {
        public delegate void Greet();

        private static Dictionary<int, Greet> time = new Dictionary<int, Greet>() { { 3, GoodNight }, { 12, GoodMorning }, { 18, GoodDay }, { 22, GoodEvening } };

        public static void Output()
        {
            time.First(item => DateTime.Now.Hour <= item.Key).Value();
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Доброго ранку!");
        }
        private static void GoodDay()
        {
            Console.WriteLine("Добрий день!");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Добрий вечір!");
        }
        private static void GoodNight()
        {
            Console.WriteLine("Доброї ночі!");
        }
    }
}
