using System;

namespace main_1
{
    public class Task4 : ITask
    {
        public void Run()
        {
            int count = 52;
            int filled = count / 3;
            int remains = count % 3;
            Console.WriteLine("52 картинки по 3 в ряд");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Заполнено рядов: {filled}");
            Console.WriteLine($"Остаток: {remains}");
        }
    }
}