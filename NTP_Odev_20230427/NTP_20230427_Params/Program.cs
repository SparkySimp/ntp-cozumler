using System;
using System.Linq;

namespace NTP_20230427_Params
{
    internal static class SayiIslemleri
    {
        static public decimal Sum(params double[] numbers) => new decimal(numbers.Sum());
        static public void Print(params decimal[] numbers)
        {
            if(numbers.Length <= 0)
            {
                Console.Error.WriteLine("No arguments thus ending method");
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        static public void Print(string str) => Console.Error.WriteLine($"İsim geldi yazdırılıyor: {str}");
    } 


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rekt = new Rectangle(10, 40);
            Rectangle rekt2 = new Rectangle(height: 40);

            Triangle triangle = new Triangle(3, 4, 5);
            Triangle triangle1 = new Triangle(0, 0, 0)
            {
                Edge1 = 20,
                Edge2 = 50,
                Edge3 = 42
            };
            Console.WriteLine(new string('=', 20));
            Console.WriteLine($"rekt Dikdörtgeninin Alanı: {rekt.Area}");
            Console.WriteLine($"rekt Dikdörtgeninin Çevresi: {rekt.Circumference}");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("ABC üçgeninin alanı: {0}", triangle.Area);
            Console.WriteLine("ABC üçgeninin çevresi: {0}", triangle.Circumference);
            Console.WriteLine(new string('=', 20));

            double[] ns = Enumerable.Range(1, 15).Select(Convert.ToDouble).ToArray();
            
            Console.WriteLine("1..15 arası sayıların toplamı: {0}", SayiIslemleri.Sum(ns));
            Console.WriteLine("Params 1: {0}", SayiIslemleri.Sum(1, 2, 3, 7, 6, 11, 42));
            Console.WriteLine(new string('=', 20));
            SayiIslemleri.Print(11, 23, 64, 11, 45, 56, 45, 963, 415, 452, 485, 461, 265);
        }
    }
}
