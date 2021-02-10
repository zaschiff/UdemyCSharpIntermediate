using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Stopwatch s = new Stopwatch();
            string input = "";
            Console.WriteLine("If you would like to start a stop watch press enter");
            input = Console.ReadLine();
            while (String.IsNullOrEmpty(input)){
                s.Start();
                Console.WriteLine("Stop watch has started... Press enter to pause the stopwatch");
                Console.WriteLine("Type stop to stop the stopatch");
                input = Console.ReadLine();
                s.Stop();
                Console.WriteLine(s.Timer);
            }
        }
    }
}
