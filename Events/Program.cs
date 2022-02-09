﻿using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var theClock = new Clock();
            var visibleClock = new VisibleClock();
            visibleClock.Subscribe(theClock);
            var logger = new Logger();
            logger.Subscribe(theClock);
            theClock.RunClock();


        }
    }
}
