using System;

namespace PruebaArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] al = new Alumno[5];
            for (int i = 0; i <al.Length; i++)
            {
                al[i] = new Alumno();

                
                Console.WriteLine("Nombre:");
                al[i].Nombre = Console.ReadLine();
                Console.WriteLine(" Matricula:");
                al[i].Matricula = Console.ReadLine();
                Console.WriteLine(" Carrera:");
                al[i].Carrera = Console.ReadLine();

            }
            for (int i = 0; i <al. Length; i++)
            {
                Console.WriteLine(al[i].ToString());
           
            }
           

            Console.ReadKey();
        }


    }
}
