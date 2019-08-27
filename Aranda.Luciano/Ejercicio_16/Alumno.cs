using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        string apellido;
        string nombre;
        static int legajo;

        static Alumno()
        {
            legajo = 0;
        }

        public Alumno(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            legajo++;
        }

        //------------------------------------------------

        public string Mostrar()
        {
            return this.nombre + " " + this.apellido + " " + Alumno.legajo;
        }
    }
}
