using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Var15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // метод Степень
            double Step(double osn, int nn)
            {
                double st = 1;
                for (int i = 1; i <= nn; i++)
                { st = st * osn; }
                return st;
            }
            // метод Сумма
            double Summa(double[] mas)
            {
                double sum = 0;
                for (int i = 0; i < mas.Length; i++)
                { sum = sum + mas[i]; }
                return sum;
            }
            Random random = new Random();
            Console.Write("Введите t=");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Введите m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите c=");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите a=");
            int a = int.Parse(Console.ReadLine());
            double[] x = new double[t];
            double[] y = new double[m];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = random.Next(0, 2);
            }
            for (int j = 0; j < y.Length; j++)
            {
                y[j] = random.Next(0, 2);
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"x{i + 1}={x[i]}");
            }
            for (int j = 0; j < y.Length; j++)
            {
                Console.WriteLine($"y{j + 1}={y[j]}");
            }

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Step(x[i] + a * t, t);
            }
            for (int j = 0; j < y.Length; j++)
            {
                y[j] = c * y[j] / (Step(a, t) + Step(c, m));
            }
            double F = Summa(x) + Summa(y);
            Console.WriteLine($"F={F}");
        }
    }
}
