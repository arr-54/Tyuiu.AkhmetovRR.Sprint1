using Tyuiu.AkhmetovRR.Sprint1.Task6.V1.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            DataService dataService = new DataService();
            string result = dataService.SymbolCode(x);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
