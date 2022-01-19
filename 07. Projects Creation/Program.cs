using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());
            int hours = project * 3;

            Console.WriteLine($"  The architect {architect} will need {hours}  hours to complete {project} project/s.");
        }
    }
}
