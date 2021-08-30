using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.Write("numero 1: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("numero 2: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("resultado " + (numero1 + numero2));

            Console.ReadKey();
        }
    }
}
