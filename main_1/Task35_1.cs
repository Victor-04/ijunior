using System;
using System.Reflection;
using System.Runtime.InteropServices.Expando;

namespace main_1
{
    public class Task35_1 : ITask
    {
        public void Run()
        {
            const int BorderArray = 30;
            const int MaxBorderNumber = 9;
            const int MinBorderNumber = 1;

            Random random = new Random();
            int row = BorderArray;

            Console.WriteLine();
            Console.WriteLine($"row: {row}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            int[] array = new int[row];

            for (int i = 0; i < row; i++)
            {
                array[i] = random.Next(MinBorderNumber, MaxBorderNumber + 1);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            // ---------------------------

            int arrayLength = array.Length;
            int numberRepetitions = 0;
            int numberTarget = 0;
            int numberRepetitionsMax = 0;
            int numberTargetMax = 0;

            int[] indexElements = new int[] { 0 };
            numberTarget = array[0];
            numberRepetitions++;

            for (int i = 1; i < arrayLength; i++)
            {
                if (array[i] == array[i - 1])
                {
                    int lengthArray = indexElements.Length;
                    int[] tempArray = new int[indexElements.Length + 1]; ;

                    for (int j = 0; j < lengthArray; j++)
                    {
                        tempArray[j] = indexElements[j];
                    }

                    tempArray[lengthArray] = i;
                    indexElements = tempArray;
                    numberTarget = array[i];
                    numberRepetitions++;
                }
                else 
                {
                    if (numberRepetitions > numberRepetitionsMax)
                    {
                        numberTargetMax = numberTarget;
                        numberRepetitionsMax = numberRepetitions;
                    }
                        indexElements = new int[] { i };
                        numberTarget = array[i];
                        numberRepetitions = 1;
                }
            }

            Console.Write($"\n Число ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(numberTargetMax);
            Console.ResetColor();
            Console.Write(" повторяется ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(numberRepetitionsMax);
            Console.ResetColor();
            Console.WriteLine(" раза подряд");
        }
    }
}