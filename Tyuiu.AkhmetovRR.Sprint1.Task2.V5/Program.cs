using Tyuiu.AkhmetovRR.Sprint1.Task2.V5.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task2.V5
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
            DataService dataService = new DataService();
            int result = dataService.Calculate(a);
            Console.WriteLine("Площадь боковой поверхности куба равна:" + result);
            Console.ReadLine();
        }
    }
}
