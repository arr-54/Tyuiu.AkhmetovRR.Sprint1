using Tyuiu.AkhmetovRR.Sprint1.Task5.V4.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k = double.Parse(Console.ReadLine());
            DataService dataService = new DataService();
            int result = dataService.Calculate(k);
            Console.WriteLine("Полных часов прошло:" + result);
            Console.ReadLine();
        }
    }
}