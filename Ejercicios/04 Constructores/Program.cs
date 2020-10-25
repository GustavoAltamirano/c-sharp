using System;

namespace _04_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.PrimerNombre = "Gustavo";
            a.SegundoNombre = "Alfredo";

            Alumno b = new Alumno();
            b.id = 2;
            b.PrimerNombre = "Walter";
            b.SegundoNombre = "Augusto";

            Alumno c = new Alumno(3);
            c.PrimerNombre = "Juana";
            c.SegundoNombre = "Maria";


            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
        }
    }
}
