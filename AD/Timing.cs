using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;

namespace AD
{
    public class Timing
    {
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);

        private readonly long _frequency;
        private long _start;
        private long _stop;
        /// <summary>
        /// Prevents a default instance of the Timing class from being created from the outer scope.
        /// </summary>
        private Timing()
        {
            if (QueryPerformanceFrequency(out _frequency) == false)
            {
                // Frequency not supported
                throw new Win32Exception();
            }
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)0x0001;
        }

        private double Duration(TimeUnit timeUnit)
        {
            return (((double)(_stop - _start) / ((double)_frequency) * (int)timeUnit));
        }

        /// <summary>
        /// Starts the timing.
        /// </summary>
        private void Start()
        {
            QueryPerformanceCounter(out _start);
        }

        /// <summary>
        /// Stops the timing.
        /// </summary>
        private void Stop()
        {
            QueryPerformanceCounter(out _stop);
        }

        /// <summary>
        /// TimeUnit enum for easy selection of a time unit.
        /// </summary>
        public enum TimeUnit : int
        {
            Seconds = 1,
            Miliseconds = 1000,
            Nanoseconds = 1000000
        }

        public class NoReturn
        {
        }

        public class Result<T>
        {
            public T ReturnValue { get; set; }

            public double Time { get; set; }
        }

        public static Result<NoReturn> GetTime(Action action, TimeUnit timeUnit)
        {
            return GetTime(() =>
            {
                action.Invoke();
                return new NoReturn();
            }, timeUnit);
        }
        public static Result<T> GetTime<T>(Func<T> function, TimeUnit timeUnit)
        {
            var timing = new Timing();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            timing.Start();
            var returnValue = function.Invoke();
            timing.Stop();

            return new Result<T>
            {
                Time = timing.Duration(timeUnit),
                ReturnValue = returnValue
            };
        }
    }
}
