using System;

namespace _13_Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string pass;
            Console.Clear();
            Console.WriteLine("ORDENES Y FACTURACION  --  CAFEMANIA");
            Console.WriteLine("====================================");
            Console.WriteLine("Ingrese su usuario: ");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese su password: ");
            pass = Console.ReadLine();
            
            if (usuario == "admin")
            {
                if (pass == "password")
                {
                    Console.WriteLine("ACCESO SATISFACTORIO");
                }
            }else
            {
                Console.WriteLine("ERROR EN USUARIO Y/O PASSWORD");
            }
        }
    }
}
