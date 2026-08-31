using System;

namespace main_1
{
    public class Task33 : ITask
    {
        public void Run()
        {
            const int BorderArray = 30;
            const int MaxBorderNumber = 99;
            const int MinBorderNumber = 10;

            Random random = new Random();
            int row = BorderArray;

            Console.WriteLine();
            Console.WriteLine($"rows: {row}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            int[] array = new int[row];

            for (int i = 0; i < row; i++)
            {
                array[i] = random.Next(MinBorderNumber, MaxBorderNumber + 1);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            int arrayLength = array.Length;
            string localMaxElements = "";

            for (int i = 0; i < arrayLength; i++)
            {
                if (i == 0)
                {
                    if (array[i] > array[i + 1])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i] + " ");
                        Console.ResetColor();
                        localMaxElements += $"{array[i]} ";
                    }
                    else
                    {
                        Console.Write(array[i] + " ");
                    }
                }
                else if (i == arrayLength - 1)
                {
                    if (array[i - 1] < array[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i] + " ");
                        Console.ResetColor();
                        localMaxElements += $"{array[i]} ";
                    }
                    else
                    {
                        Console.Write(array[i] + " ");
                    }
                }
                else
                {
                    if (array[i - 1] < array[i] && array[i] > array[i + 1])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i] + " ");
                        Console.ResetColor();
                        localMaxElements += $"{array[i]} ";
                    }
                    else
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(localMaxElements);
        }
    }
}