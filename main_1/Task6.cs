using System;
using System.Collections.Generic;

namespace main_1
{
    public class Task6 : ITask
    {
        public void Run()
        {
            ulong goldBalance = 0;
            ulong cristalBalance = 0;
            ulong cristalPrice = 10;
            ulong cristalRequirement = 0;

            Console.WriteLine("Сколько у вас золота?");
            goldBalance = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"У Вас: {goldBalance} золота");
            Console.WriteLine($"Цена 1 Кристалла: {cristalPrice} золота");
            Console.WriteLine("Сколько хотите купить Кристалов?");
            cristalRequirement = Convert.ToUInt64(Console.ReadLine());

            try
            {
                checked
                {
                    goldBalance = goldBalance - cristalRequirement * cristalPrice;
                    cristalBalance = cristalRequirement;
                }
            }
            catch (OverflowException)
            {
                cristalBalance = goldBalance / cristalPrice;
                goldBalance = goldBalance - (cristalBalance * cristalPrice);
            }

            Console.WriteLine("----------------- конец сделки -----------------");
            Console.WriteLine($"Баланс Кристалов: {cristalBalance}");
            Console.WriteLine($"Баланс золота: {goldBalance}");

        }
    }
}