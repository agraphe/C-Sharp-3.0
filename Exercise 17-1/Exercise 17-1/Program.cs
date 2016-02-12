using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Exercise_17_1
{
    // a class to hold the message to display
    public class CountDownClockEventArgs : EventArgs
    {
        public string message;
        public CountDownClockEventArgs(string message)
        {
            this.message = message;
        }
    }
    // The publisher; the class to which other
    // classes will subscribe. Provides the delegate TimeExpired
    // that fires when the requested amount of time has passed
    public class CountDownClock
    {
        private int seconds;
        private string message;

        // tell me the message to display, and how many seconds to wait

        public CountDownClock(string message, int seconds)
        {
            this.message = message;
            this.seconds = seconds;
        }

        // the delegate
        public delegate void TimesUpEventHandler
        (
             object countDownClock,
             CountDownClockEventArgs alarmInformation
        );

        // an instance of the delegate
        public TimesUpEventHandler TimeExpired;
        // Wait until time has elapsed, then check to see 
        // if anyone is listening, and send the message
        public void Run()
        {
            // sleep until time has elapsed
            Thread.Sleep(seconds * 1000);
            if (TimeExpired != null)
            {
                // Create the CountDownClockEventArgs to hold the message
                CountDownClockEventArgs e =  new CountDownClockEventArgs(this.message);
                // fire the event
                TimeExpired(this, e);
            }
        }              // end run
    }                 // end class

    // an observer
    public class CountDownTimerDisplay
    {
        CountDownClock.TimesUpEventHandler myHandler;
        public CountDownTimerDisplay(CountDownClock cdc)
        {
            myHandler = new CountDownClock.TimesUpEventHandler(TimeExpired);
            // register the event handler and start the timer
            cdc.TimeExpired += myHandler;
        }
        // Alert the user that the time has expired
        public void TimeExpired(object theClock, CountDownClockEventArgs e)
        {
            Console.WriteLine("You requested to receive this message: {0}", e.message);
        }
    }
    // an observer.
    public class Tester
    {
        public void Run()
        {
            Console.Write("Enter your alert message: ");
            string message = Console.ReadLine();

            // Ask for how many seconds to wait
            Console.Write("How many seconds to wait? ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            // Create the clock class
            CountDownClock cdc = new CountDownClock(message, seconds);

            // Create the observer class
            CountDownTimerDisplay display = new CountDownTimerDisplay(cdc);
            cdc.Run();
        }
    }
    public class Program
    {
        public static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
