using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_5
{
    class Program
    {
        // Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида: 1 0 1 0 1, 0 1 0 1 0
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] twoDimensionalArray = new int[n, n] { { 1, 0, 1, 0, 1 }, { 0, 1, 0, 1, 0 } };

        }
    }
}
