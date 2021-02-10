using System;

namespace Exercise1 {
    class Stopwatch {
        private TimeSpan zeroTime = new TimeSpan(0,0,0);
        private TimeSpan duration = new TimeSpan();
        private DateTime StartTime;
        private DateTime StopTime;
        private bool started = false;
        public Stopwatch() {}

        public void Start() {
            try {
                if (!started) {
                    if(TimeSpan.Compare(duration, zeroTime) != 0) {
                        duration = duration + (StartTime - StopTime);
                    }
                    StartTime = DateTime.Now;
                    started = true;
                } else {
                    throw new StopWatchException("Error: Stopwatch has already started!");
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public void Stop() {
            try {
                if(started) {
                    StopTime = DateTime.Now;
                    started = false;
                    if(TimeSpan.Compare(duration, zeroTime) == 0) {
                        duration = StopTime -StartTime;
                    } else {
                        duration = duration + (StopTime - StartTime);
                    }
                } else {
                    throw new StopWatchException("Error: Stopwatch is not running!");
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public TimeSpan Timer {
            get {
                return duration;
            }
        }
    }

    public class StopWatchException : Exception {
        public StopWatchException() {}

        public StopWatchException(string message) : base(message) {}

        public StopWatchException(string message, Exception inner) : 
            base(message, inner) {}
    }
}