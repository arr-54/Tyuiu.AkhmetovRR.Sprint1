﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AkhmetovRR.Sprint1.Task2.V5.Lib
{
    public class DataService : ISprint1Task2V5
    {
        public double Calculate(double a)
        {
            return 6 * Math.Pow(a, 2);
        }

        int ISprint1Task2V5.CalculateSideSquare(int value)
        {
            throw new NotImplementedException();
        }
    }
}