using System;

namespace REC_83
{
    class Program
    {
        static long Pow(long x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n % 2 == 0)
            {
                var result = Pow(x, n / 2);
                return result * result;
            }
            else
            {
                return x * Pow(x, n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите основание: ");
            var x = long.Parse( Console.ReadLine());
            Console.Write("Введите степень: ");
            var n = int.Parse(Console.ReadLine());
            Console.Write(Pow(x, n));
            Console.ReadKey();
        }
    }
}
