//розібрати приклад
using System;
using System.Collections.Generic;

namespace z4
{
    class Program
    {
        delegate int Operation(int a, int b);

        static void Main(string[] args)
        {
            Dictionary<String, Operation> op = new Dictionary<String, Operation>();
            op["add"] = (a, b) => a + b;
            op["mult"] = (a, b) => a * b;
            Console.WriteLine(op["add"](2, 3));
            Console.WriteLine(op["mult"](6, 7));

            Console.ReadKey();
        }
    }
}
