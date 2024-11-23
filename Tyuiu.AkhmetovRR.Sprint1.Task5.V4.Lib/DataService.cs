﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AkhmetovRR.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int Calculate(double k)
        {
            return (int) Math.Round(k / 3600) - 1;
        }

        int ISprint1Task5V4.SecondsToHours(int time)
        {
            throw new NotImplementedException();
        }
    }
}