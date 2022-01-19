using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            double square =double.Parse( Console.ReadLine());
            double sum = square * square;
            Console.WriteLine($"{square * square:f3}");
        }
    }
}
