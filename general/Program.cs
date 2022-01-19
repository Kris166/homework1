using System;

namespace general
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                double vacation = double.Parse(Console.ReadLine());
                int puzzle = int.Parse(Console.ReadLine());
                int dolls = int.Parse(Console.ReadLine());
                int bears = int.Parse(Console.ReadLine());
                int minions = int.Parse(Console.ReadLine());
                int trucks = int.Parse(Console.ReadLine());

                int toys = puzzle + dolls + bears + minions + trucks;
                double totalPrise = trucks * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks * 2;

                if (toys >= 50)
                {
                    totalPrise = totalPrise - totalPrise * 0.25;
                }
                totalPrise = totalPrise - totalPrise * 0.1;
            }
            if (totalPrise >= vacantion)
            {
                Console.WriteLine($"Yes! {totalPrise}lv left.");

            }
            else
                Console.WriteLine($"Not enough money! {vacantion - totalPrise:F2} lv needed.");
        }
    }
}

