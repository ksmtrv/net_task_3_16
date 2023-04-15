using System;

namespace net_task_3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hour --> ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minute --> ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");

            Day day = new Day(x,y);

            Console.WriteLine(day);
            Console.WriteLine(day.Define());
        }
    } 
}