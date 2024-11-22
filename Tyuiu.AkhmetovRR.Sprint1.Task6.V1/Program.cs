using Tyuiu.AkhmetovRR.Sprint1.Task6.V1.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x = char.Parse(Console.ReadLine());
            DataService dataService = new DataService();
            int result = dataService.Calculate(x);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
