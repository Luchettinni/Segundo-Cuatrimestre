using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Alumno
    {
        #region Atributos

        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;

        #endregion

        #region Propiedades

        public string Apellido { get { return apellido; } }
        public ETipoExamen Examen { get { return examen; } }
        public int Legajo { get { return legajo; } }
        public string Nombre { get { return nombre; } }

        #endregion

        #region Constructor

        public Alumno(string nombre, string apellido, int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }

        #endregion

        #region Metodos

        public static string Mostrar(Alumno a)
        {
            return "Nombre: " + a.nombre.PadRight(15) + " Apellido: " + a.apellido.PadRight(15) + " Legajo: " + a.legajo;
        }

        public static int OrdernarPorApellido(Alumno a, Alumno b) // HACER LUCHETOOLS CON ESTO
        {

            int index = 0;
            int retorno = 0;

            while ( !Object.Equals(index, a.apellido.Length))
            {
                if (Object.Equals(a.apellido[index], b.apellido[index]))
                {
                    index++;
                }
                else if (a.apellido[index] > b.apellido[index])
                {
                    retorno = 1;
                    break;
                }
                else if (a.apellido[index] < b.apellido[index])
                {
                    retorno = -1;
                    break;
                }
            }

            return retorno;

        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(Alumno a, Alumno b)
        {
            bool retorno = false;

            if (Object.Equals(a, null) && Object.Equals(b, null))
            {
                if (Object.Equals(a.legajo, b.legajo))
                {
                    retorno = true;
                }
            }

            return retorno;

        }

        public static bool operator !=(Alumno a, Alumno b)
        {
            bool retorno = false;

            if (Object.Equals(a, null) && Object.Equals(b, null))
            {
                if (!(a == b))
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        #endregion
    }
}
