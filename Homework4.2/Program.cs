using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int y;
            int x = 0;
            int min = 0;
            // Проверка введённых параметров на положительное число
            do
            {
                Console.WriteLine(" Введите длинну последовательности: ");
                y = int.Parse(Console.ReadLine());
                if (y <= 0)
                {
                    Console.WriteLine(" Неверное значение\n");
                }
            } while (y <= 0);
            int[] numbers = new int[y];
            do
            {
                Console.WriteLine($" Введите {x+1}ое целое число: ");
                numbers[x] = int.Parse(Console.ReadLine());
                if (numbers[x] < min && numbers[x] < Int32.MaxValue)
                {
                    min = numbers[x];                     
                }
                x++;
                
            } while (x < y);
            Console.WriteLine("\n");
            Console.Write("|");
            for (int i = 0; i < y; i++)
            {
                Console.Write($"{numbers[i],5} ");
            }
            Console.WriteLine("|");
            Console.WriteLine("\n Меньшее число \n");
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
