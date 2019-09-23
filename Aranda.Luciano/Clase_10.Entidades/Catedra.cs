using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos { get { return alumnos; } }

        public Catedra()
        {
            alumnos = new List<Alumno>();
        }

        public static bool operator ==( Catedra c, Alumno a )
        {
            bool retorno = false;

            foreach( Alumno alumno in c.alumnos )
            {
                if ( Object.Equals( a, alumno ) )
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Catedra c, Alumno a)
        {
            bool retorno = false;

            if ( !(c == a) )
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator +(Catedra c, Alumno a)
        {
            bool retorno = true;

            if ( c == a )
            {
                retorno = false;
            }
            else
            {
                c.alumnos.Add(a);
            }

            return retorno;
        }

        public static bool operator -(Catedra c, Alumno a)
        {
            bool retorno = true;

            if ( !(c + a) )
            {
                c.alumnos.RemoveAt(a|c);
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }

        public static int operator |(Alumno a, Catedra c)
        {
            return c.alumnos.IndexOf(a);
        }
    }
}
