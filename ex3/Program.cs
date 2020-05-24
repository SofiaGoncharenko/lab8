//приклад 3
using System;
using System.Collections.Generic;
using System.Linq;

namespace ex3
{
    class Program
    {
        public static string MySelector(string value)
        {
            return value.ToUpper();
        }

        static void Main(string[] args)
        {
            //масив
            string[] arrNames = new string[] { "Hello", "Good Morning", "Bye" };
            //делегат Func
            Func<string, string> selector = MySelector;
            //перетворюємо слова
            IEnumerable<string> convertedNames = Enumerable.Select(arrNames, selector);
            //показ результату на екрані
            foreach(string str in convertedNames)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
