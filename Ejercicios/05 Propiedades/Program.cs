using System;

namespace _05_Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.id = 1;
            a.PrimerNombre = "Gustavo";
            a.SegundoNombre = "Alfredo";
            Console.WriteLine("Hello World!");
        }
    }
}
