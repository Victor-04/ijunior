using System;
using System.Collections.Generic;
using System.Reflection;

namespace main_1
{
    public class Task25 : ITask
    {
        const string textCommandHelp = "/help";
        const string textCommandSysInfo = "/info";
        const string textCommandRandomNumber = "/random";
        const string textCommandClear = "/clean";
        const string textCommandExit = "/exit";

        public void Run()
        {
            string comand = "";

            Console.Clear();
            Console.WriteLine("Enter '/help' to get help");

            while (comand != textCommandExit)
            {
                Console.Write("Your Command: "); 
                comand = Console.ReadLine();
                Console.WriteLine();

                switch (comand)
                {
                    case textCommandHelp:
                        CommandHelp(); 
                        break;

                    case textCommandSysInfo:
                        CommandSysInfo();
                        break;

                    case textCommandRandomNumber:
                        CommandRandomNumber();
                        break;

                    case textCommandClear:
                        Console.Clear();
                        break;

                    case textCommandExit:
                        break;

                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }

                if (comand != textCommandClear)
                {
                    Console.WriteLine();
                }
            }
        }

        // ----------------------------------------------------------------- //

        private void CommandHelp()
        {
            Console.WriteLine($"  {textCommandHelp}     - Show this help message");
            Console.WriteLine($"  {textCommandSysInfo}     - Display system information");
            Console.WriteLine($"  {textCommandRandomNumber}   - Generate a random number");
            Console.WriteLine($"  {textCommandClear}    - Clear the console screen");
            Console.WriteLine($"  {textCommandExit}     - Exit the program");
        }

        private void CommandSysInfo()
        {
            Console.WriteLine("=== SYSTEM INFORMATION ===\n");
            Console.WriteLine($"ОС: {Environment.OSVersion}");
            Console.WriteLine($"CPU: Intel Core i5-12400K @ 3.60GHz");
            Console.WriteLine($"RAM (Total): 32.00 GB");
            Console.WriteLine($"RAM (Free): 24.50 GB");

            Console.WriteLine("\n--- GRAPHICS INFORMATION ---\n");
            Console.WriteLine($"GPU: NVIDIA GeForce RTX 4080");
            Console.WriteLine($"Video Memory: 16.00 GB");
        }

        private void CommandRandomNumber()
        {
            var random = new Random();
            int randValue = random.Next(9999999);
            Console.WriteLine($"{randValue}");
        }
    }
}