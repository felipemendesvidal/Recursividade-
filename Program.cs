using System;

namespace recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            fibo.GerarFibonacci(0,1,15);
            Console.WriteLine(fibo.GerarFatorial(5));
        }
    }
}
