using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int trird= int.Parse(Console.ReadLine());

            int time = first + second + trird;
            int min = time / 60;
            int sec = time % 60;
            if (sec<010)
            {
                Console.WriteLine($"{min}:0{sec}");
            }            
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }                
        }
    }
}
