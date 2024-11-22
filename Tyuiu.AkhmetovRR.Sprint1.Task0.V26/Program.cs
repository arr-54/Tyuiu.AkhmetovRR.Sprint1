using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint1.Task0.V26.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double result = ds.Calculate();

            Console.WriteLine("Результат вычисления выражения:" + result);

            Console.ReadLine();
        }
    }
}
