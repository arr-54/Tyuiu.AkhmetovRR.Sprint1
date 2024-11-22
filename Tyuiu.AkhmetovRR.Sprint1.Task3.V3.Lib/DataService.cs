using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AkhmetovRR.Sprint1.Task3.V5.Lib
{
    public class DataService : ISprint1Task3V5
    {
        public double Calculate(double a, double b, double c)
        {
            return a * b * c;
        }

        double ISprint1Task3V5.DistanceLength(double mapScale, double distanceBetweenPoints)
        {
            throw new NotImplementedException();
        }
    }
}