using Tyuiu.AkhmetovRR.Sprint1.Task1.V23.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, a;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ds.Calculate(x, a));

            Console.ReadLine();
        }
    }
}