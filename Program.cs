using System;

namespace LAB03_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            Console.Write("Введите первую сторону: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите вторую сторону: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите третью сторону: ");
            double c = double.Parse(Console.ReadLine());

            double p = a + b + c;

            double s = p / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"Периметр: {p}");
            Console.WriteLine($"Площадь: {area:F2}");
        }
    }
}
