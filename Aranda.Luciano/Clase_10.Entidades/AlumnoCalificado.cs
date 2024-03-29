﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class AlumnoCalificado : Alumno
    {
        protected double nota;

        public double Nota { get { return this.nota; } }

        public AlumnoCalificado(Alumno a, double nota) : base(a.Nombre, a.Apellido, a.Legajo, a.Examen)
        {
            this.nota = nota;
        }

        public AlumnoCalificado( string nombre, string apellido, int legajo, ETipoExamen examen, double nota) : this(new Alumno(nombre,apellido,legajo,examen), nota )
        {
            
        }

        public override string Mostrar()
        {
            string retorno = "Nombre: " + this.nombre.PadRight(15) + " Apellido: " + this.apellido.PadRight(15) + " Legajo: " + this.legajo.ToString().PadLeft(4, '0') + " Examen: " + this.examen + " Nota:" + this.nota + "\n";
            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
