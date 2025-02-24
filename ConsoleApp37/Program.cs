using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        public static int[] Input(int n)
        {
            int[] array= new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i;
            }
            return array;
        }

        public static void Output(int[] array)
        {
            Console.WriteLine("Элементы массива : ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] omas = Input(n);
            Output(omas);
            Console.ReadKey();
        }
    }
}
