using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение параметра x: ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = (Math.Sin(x) - Math.Cos(x)) / 5;
            Console.WriteLine($"Значение F ={F}.");
            Console.ReadKey();
            return;
        }
    }

}
