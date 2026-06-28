using System;
using System.Collections.Generic;

namespace main_1
{
    public class Task7 : ITask
    {
        public void Run()
        {
            uint countPeople = 0;
            uint timeMinuteWait = 10;
            uint TimeTotalWait = 0;

            Console.WriteLine("Сколько людей в очереди?");
            countPeople = Convert.ToUInt32(Console.ReadLine());
            TimeTotalWait = countPeople * timeMinuteWait;
            Console.WriteLine($"Вы должны отстоять в очереди {TimeTotalWait / 60} часа и {TimeTotalWait % 60} минут.");

        }
    }
}