using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;

namespace main_1
{
    public class Task27 : ITask
    {

        public void Run()
        {
            char symbol = '-';
            int lengthLine = 0;
            string inputLine = "";

            Console.Write("Ввидите символ: ");
            inputLine = Console.ReadLine();

            if (inputLine.Length > 1)
            {
                Console.Write("Вы ввели больше одного символа!\nПовторите попытку и введите один символ!\n");
                return;
            }

            symbol = inputLine[0];

            Console.Write("Ввидите Имя: ");
            inputLine = Console.ReadLine();

            inputLine = symbol + inputLine + symbol;
            lengthLine = inputLine.Length;

            Console.WriteLine();
            for (int i = 0; i < lengthLine; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();

            Console.WriteLine(inputLine);

            for (int i = 0; i < lengthLine; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}