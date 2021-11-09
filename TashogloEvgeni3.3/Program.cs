using System;

namespace Tashoglo3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите l:");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите k:");
                double k = double.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 1, h = 1; 1 <= l; i++, h += 2)
                {
                    long F = 1;
                    for (int j = 1; j <= h; j++) F *= j;
                    S += Math.Pow(-(k + 1), 2);
                }
                Console.WriteLine("S={0:F2}", S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}