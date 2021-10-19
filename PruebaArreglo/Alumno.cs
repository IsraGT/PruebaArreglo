using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaArreglo
{
    class Alumno
    {
        private string nombre;
        private string matricula;
        private string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }


        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Alumno() 
        {
            nombre = "";
            matricula = "";
            carrera = "";
        }
       public Alumno(string nombre, string matricula, string carrera) 
        {
            this.nombre = nombre;
            this.matricula = matricula;
            this.carrera = carrera;
       }
        public override string ToString()
        {
            return nombre + "" + matricula + "" + carrera;
        }
    } 

    
    
}
