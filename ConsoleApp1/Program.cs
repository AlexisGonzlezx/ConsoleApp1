using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro[] arregloLibros = new Libro[5];
            for (int i = 0; i < arregloLibros.Length; i++)
            {
                arregloLibros[i] = new Libro();
                arregloLibros[i].Titulo = "Adios";
                arregloLibros[i].Autor = "Pedro";
                arregloLibros[i].Codigo = "T2565";
            }

            for (int i = 0; i < arregloLibros.Length; i++)
            {
                Console.WriteLine(arregloLibros[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
