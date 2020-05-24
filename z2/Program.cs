/*Написати статичний метод ReadFiles, що виконує вказані дії над вмістом файлу.
Формальні параметри : файл, задана дія – об'єкт Action/Func.
Використовуючи написаний метод:
 вивести вміст файлу на екран;
 вивести на екран всі числа! (числа складаються с цифр);
 замінити у файлі всі коми/крапки/зірочки() на пробіли.
Після виклику останньої дії – вивести вміст файлу на екран.*/
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void ReadFilesAct(string file, Action<String> act)
        {
            String s;

            try
            {
                using(StreamReader sr = new StreamReader(file))
                {
                    s = sr.ReadToEnd();
                    act(s);
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ReadFilesFunc(string file, Func<String, String> act)
        {
            String s;

            try
            {
                s = File.ReadAllText(file);
                File.WriteAllText(file, act(s));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Show(String s)
        {
            Console.WriteLine(s);
        }

        static void ShowNums(String s)
        {
            try
            {
                Queue numbers = new Queue();
                string[] array = s.Split(' ');

                int k;
                for (int i = 0; i < array.Length; i++)
                {
                    if (Int32.TryParse(array[i], out k))
                    {
                        numbers.Enqueue(k);
                    }
                }

                foreach(int item in numbers)
                {
                    Console.Write(item + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static String Replace(String s)
        {
            StringBuilder sb = new StringBuilder(s);
            for(int i = 0; i < sb.Length; i++)
            {
                if(sb[i] == ',' || sb[i] == '.' || sb[i] == '*')
                {
                    sb[i] = ' ';
                }
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            String file1 = "z2.txt";
            String file2 = "z2_1.txt";

            Console.WriteLine("Reading");
            ReadFilesAct(file1, (Action<String>)Show);
            Console.WriteLine("\nNumbers");
            ReadFilesAct(file1, (Action<String>)ShowNums);
            Console.WriteLine("\n\nReplace");
            ReadFilesFunc(file2, Replace);
            Console.WriteLine("Result in file");

            Console.ReadKey();
        }

    }
}
    

