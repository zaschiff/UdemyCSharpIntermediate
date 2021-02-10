using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push("Molly");

            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            s.Clear();

            Console.WriteLine(s.Length);
        }
    }
}
