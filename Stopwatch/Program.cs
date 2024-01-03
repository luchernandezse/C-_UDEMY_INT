using System;

namespace Stopwatch
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXCERSISE 1: DESIGN A STOPWATCH \n" + "Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should \r\nprovide two methods: Start and Stop. We call the start method first, and the stop method next. \r\nThen we ask the stopwatch about the duration between start and stop. Duration should be a \r\nvalue in TimeSpan. Display the duration on the console. ");
            Console.WriteLine("We should also be able to use a stopwatch multiple times. So we may start and stop it and then \r\nstart and stop it again. Make sure the duration value each time is calculated properly. \r\nWe should not be able to start a stopwatch twice in a row (because that may overwrite the initial \r\nstart time). So the class should throw an InvalidOperationException if its started twice.");
            Console.WriteLine("Educational tip: The aim of this exercise is to make you understand that a class should be \r\nalways in a valid state. We use encapsulation and information hiding to achieve that. The class \r\nshould not reveal its implementation detail. It only reveals a little bit, like a blackbox. From the \r\noutside, you should not be able to misuse a class because you shouldn’t be able to see the \r\nimplementation detail.");
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to the stopwatch project. To start the stopwatch, enter 1. To stop, enter 2. To end, enter 3.");

            var stopwatch = new Stopwatch_LCH();
            
            int order = Int32.Parse(Console.ReadLine());

            while (order != 3)
            {
                if (order == 1)
                {
                    stopwatch.Start();
                    stopwatch.message1 ();
                }
                else if (order == 2)
                {
                    stopwatch.Stop();
                    Console.WriteLine("Elapsed time: " + stopwatch.TotalTime());
                    stopwatch.message2();
                }
                else
                {
                    Console.WriteLine("Check for a valid option!!");
                }

                order = Int32.Parse(Console.ReadLine());
            }
        }
    }
}