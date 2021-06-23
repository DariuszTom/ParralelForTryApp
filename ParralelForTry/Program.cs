using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParralelForTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# For Loop");
            int number = 10;
            for (int count = 0; count < number; count++)
            {
                //Thread.CurrentThread.ManagedThreadId returns an integer that 
                //represents a unique identifier for the current managed thread.
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("Parallel For Loop");
            Parallel.For(0, number, count =>
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            });

            int loopI = 0;
            Parallel.For(0, number, loopI => 
            {
                Console.WriteLine($"{loopI.ToString()}  { Math.PI*loopI }");
                Console.WriteLine($"Petla numer {loopI}");
            });
            Console.ReadLine();
        }
    }
}
