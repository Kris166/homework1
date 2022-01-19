using System;

namespace _06._Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            //При скорост до 10 (включително) отпечатайте &quot;slow&quot;
            //При скорост над 10 и до 50(включително) отпечатайте & quot; average & quot;
            //При скорост над 50 и до 150(включително) отпечатайте & quot; fast & quot;       
            //При по-висока скорост отпечатайте &quot; extremely fast&quot;

            //При по-висока скорост отпечатайте &quot; extremely fast&quot;
             double speed = double.Parse(Console.ReadLine());
            if (speed<=10)
            {
                Console.WriteLine("slow");
            }
            else if (speed<=50)
            {
                Console.WriteLine("average");
            }
            else if (speed<=150)
            {
                Console.WriteLine("fast");
            }
            else if (speed<=1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed>1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
