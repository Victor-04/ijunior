using System;

namespace main_1
{
    public class Task36 : ITask
    {
        public void Run()
        {
            const int ArraySize = 30;
            const int MaxValue= 30;
            const int MinValue = 1;

            Random random = new Random();
            int row = ArraySize;

            Console.WriteLine();
            Console.WriteLine($"row: {row}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            int[] array = new int[row];

            for (int i = 0; i < row; i++)
            {
                array[i] = random.Next(MinValue, MaxValue + 1);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            int arrayLength = array.Length - 1;

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

        }
    }
}