using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());

            int month = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double sum = deposit + month * (deposit * (interest / 100)) / 12;
            Console.WriteLine(sum);
        }
    }
}
