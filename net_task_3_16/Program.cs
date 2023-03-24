using System;

namespace net_task_3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Часы --> ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минуты --> ");
            int y = Convert.ToInt32(Console.ReadLine());

            Day day = new Day(x,y);

            Console.WriteLine(day.ShowTime());
            Console.WriteLine(day.Define());
        }
    } 
}