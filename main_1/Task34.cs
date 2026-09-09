using System;
using System.Reflection;

namespace main_1
{
    public class Task34 : ITask
    {
        public void Run()
        {
            const string SumCommand = "sum";
            const string EndCommand = "end";

            string inputLine = "";
            int[] inputNumbers = { };
            int sumNumbers = 0;
            int occupancyCounter = 0; 

            while (true) 
            {
                Console.Write("Введите значение: ");
                inputLine = Console.ReadLine();
                Console.WriteLine();

                switch (inputLine)
                {
                    case SumCommand:

                        foreach (var item in inputNumbers)
                        {
                            sumNumbers += item;
                        }
                        break;

                    default:
                        if (inputNumbers.Length == occupancyCounter)
                        {
                            int[] arrayTemp = new int[occupancyCounter + 1];

                            for (int i = 0; i < inputNumbers.Length; i++)
                            {
                                arrayTemp[i] = inputNumbers[i];
                            }

                            arrayTemp[inputNumbers.Length] = Convert.ToInt32(inputLine);
                            inputNumbers = arrayTemp;
                            occupancyCounter++;
                        }
                        break;
                }

                if (inputLine == SumCommand || inputLine == EndCommand)
                    break;
            }

            Console.WriteLine($"sumNumbers: {sumNumbers}");
        }
    }
}