using System;

namespace Exercise {
    public class ActivtiyOne : IActivity {
        public void Execute() {
            Console.WriteLine("Executing ActivtiyOne.");
        }
    }

    public class ActivityTwo : IActivity {
        public void Execute() {
            Console.WriteLine("Executing ActivityTwo.");
        }
    }
}