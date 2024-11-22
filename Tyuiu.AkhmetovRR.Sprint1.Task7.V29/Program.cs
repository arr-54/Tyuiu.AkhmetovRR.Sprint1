using Tyuiu.AkhmetovRR.Sprint1.Task7.V29.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            DataService dataService = new DataService();
            double result = Math.Round(dataService.Calculate(x, y), 3);
            Console.WriteLine("Результат вычисления выражения: " + result);
            Console.ReadLine();
        }
    }
}