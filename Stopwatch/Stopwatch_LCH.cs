using System;

namespace Stopwatch
{
    public class Stopwatch_LCH
    {
        private DateTime _startTime;
        private DateTime _stopTime;

        public Stopwatch_LCH()
        {
        }

        public void Start()
        {
            Console.WriteLine("Time starts!!");
            _startTime = DateTime.Now;
            Console.WriteLine(_startTime);
        }

        public void Stop()
        {
            Console.WriteLine("Time Stops!!");
            _stopTime = DateTime.Now;
            Console.WriteLine(_stopTime);
        }

        public TimeSpan TotalTime()
        {
            return _stopTime - _startTime;
        }
        public void message1()
        {
            Console.WriteLine("Press 2 for stop or 3 to finish");
        }
        public void message2()
        {
            Console.WriteLine("Press 1 for start or 3 to finish");
        }
    }
}