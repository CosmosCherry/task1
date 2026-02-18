using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Даны три различных целых числа. Определить, какое из них (первое, второе или третье):
//а) самое большое; б) самое маленькое; в) является средним (средним назовем число, которое больше наименьшего из данных чисел, но меньше наибольшего).

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите а: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = int.Parse(Console.ReadLine());
            int max1 = Math.Max(a, Math.Max(b, c));
            int min1 = Math.Min(a, Math.Min(b, c));
            if (max1 == a)
            {
                Console.WriteLine($"Самое большое первое число: {a} ");
                if (min1 == b)
                {
                    Console.WriteLine($"Самое минимальное второе число: {b} ");
                    Console.WriteLine($"Среднее число: {c} ");
                }
                else
                {
                    Console.WriteLine($"Самое минимальное третье число: {c} ");
                    Console.WriteLine($"Среднее число: {b} ");
                }
            }
            else if (max1 == b)
            {
                Console.WriteLine($"Самое большое второе число: {b} ");
                if (min1 == a)
                {
                    Console.WriteLine($"Самое минимальное число: {a} ");
                    Console.WriteLine($"Среднее число: {c} ");
                }
                else
                {
                    Console.WriteLine($"Самое минимальное число: {c} ");
                    Console.WriteLine($"Среднее число: {b} ");
                }

            }
            else
            {
                Console.WriteLine($"Самое большое третье число: {c} ");
                if (min1 == a)
                {
                    Console.WriteLine($"Самое минимальное первое число: {a} ");
                    Console.WriteLine($"Среднее число: {b} ");
                }
                else
                {
                    Console.WriteLine($"Самое минимальное второе число: {b} ");
                    Console.WriteLine($"Среднее число: {a} ");
                }
            }
        }
    }
}