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
                
                al[i].Nombre = "Nombre: Pepito";
                al[i].Matricula = " Matricula: I219482";
                al[i].Carrera = " Carrera: Informatica";
            }
            for (int i = 0; i <al. Length; i++)
            {
                Console.WriteLine(al[i].ToString());
            //Profe no supe donde agregar el WriteLine y el ReadLine, una disculpa.
            }
           

            Console.ReadKey();
        }


    }
}
