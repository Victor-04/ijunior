using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;

namespace main_1
{
    public class Task29 : ITask
    {
        const int LowerBorder = 50;
        const int UpperBorder = 150;

        public void Run()
        {
            int lowerGenerate = 10;
            int upperGenerate = 25;
            int startTargetValue = 0;
            int targetValue = 0;
            int numberOccurrences = 0;

            var r = new Random();
            startTargetValue = r.Next(lowerGenerate, upperGenerate);
            targetValue = startTargetValue;

            Console.WriteLine($"Число: {startTargetValue}");

            while (startTargetValue < UpperBorder)
            {
                if (startTargetValue > LowerBorder)
                {
                    numberOccurrences ++;
                    Console.WriteLine($"Вхождение: {startTargetValue}");
                }
                startTargetValue += targetValue;
            }

            Console.WriteLine($"Кол-во кратных {targetValue}: {numberOccurrences}");
        }
    }
}