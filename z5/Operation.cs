using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Operation
    {
        private delegate double UseOperation(double a, double b);
        Dictionary<String, UseOperation> operation = new Dictionary<String, UseOperation>(4) { {"+", Plus }, { "*", Mult }, { "-", Minus }, { "/", Divide } };
        


        public static double Plus(double a, double b)
        {
            return a + b;
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Divide(double a, double b)
        {
            if(b == 0)
            {
                Console.WriteLine("Error");
                return 0;
            }
            else
            {
                return a / b;
            }

        }
        
    }
}
