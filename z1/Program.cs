/*Написати статичний метод ChangeMatrix, що виконує вказані дії над елементами матриці дійсних чисел
(матрицю заповнити рандомно або з файла!! в Main()).
Формальні параметри : матриця дійсних чисел, задана дія – об'єкт Action/Func.
Використовуючи написаний метод:
 вивести матрицю на екран;
 вивести на екран позитивні (>=0) елементи матриці;
 збільшити в три рази всі позитивні елементи матриці.
Після виклику останньої дії – вивести змінену матрицю на екран.*/

using System;

namespace z1
{
    class Program
    {
        static void MethodAct(int[,] arr, int n, int m, Action<int> act)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    act(arr[i, j]);
                }
                Console.Write("\n");
            }
        }

        static void MethodFunc(int[,] arr, int n, int m, Func<int, int> act)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = act(arr[i, j]);

                }
            }
        }

        static void Show(int num)
        {
            Console.Write(num + " ");
        }

        static void ShowPositive(int num)
        {
            if(num > 0)
            {
                Console.Write(num + " ");
            }
        }

        static int Mult3(int num)
        {
            if(num > 0)
            {
                return num * 3;
            }
            else
            {
                return num;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int n, m;
                Console.Write("Enter number of rows: ");
                n = Int32.Parse(Console.ReadLine());
                Console.Write("Enter number of columns: ");
                m = Int32.Parse(Console.ReadLine());

                int[,] matrix = new int[n, m];
                Random rand = new Random();

                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        matrix[i, j] = rand.Next(-100, 100);
                    }
                }

                Console.WriteLine("\nMatrix");
                MethodAct(matrix, n, m, (Action<int>)Show);
                Console.WriteLine("\nPositive elems");
                MethodAct(matrix, n, m, (Action<int>)ShowPositive);
                Console.WriteLine("\nMultiply");
                MethodFunc(matrix, n, m, Mult3);
                MethodAct(matrix, n, m, (Action<int>)Show);

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
