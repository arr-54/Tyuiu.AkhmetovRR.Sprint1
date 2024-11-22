using Tyuiu.AkhmetovRR.Sprint1.Task3.V5.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            DataService dataService = new DataService();
            double result = Math.Round(dataService.Calculate(a, b, c), 3);
            Console.WriteLine("Объем параллелипипеда равен:" + result);
            Console.ReadLine();
        }
    }
}
