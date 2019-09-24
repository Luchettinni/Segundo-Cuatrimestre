using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuccheTools;

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

        public virtual string Mostrar()
        {
            string retorno = "Nombre: " + this.nombre.PadRight(15) + " Apellido: " + this.apellido.PadRight(15) + " Legajo: " + this.legajo.ToString().PadLeft(4, '0') + " Examen: " + this.examen + "\n";
            return retorno;
        }

        public static int OrdernarPorApellidoAsc(Alumno a, Alumno b)
        {
            return string.Compare(a.apellido, b.apellido);
        }

        public static int OrdernarPorApellidoDes(Alumno a, Alumno b)
        {
            return -1 * OrdernarPorApellidoAsc(a, b);
        }

        public static int OrdernarPorLejagoAsc(Alumno a, Alumno b)
        {
            int retorno = 0;

            if ( a.legajo > b.legajo )
            {
                retorno = 1;
            }
            else if ( a.legajo < b.legajo )
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int OrdernarPorLejagoDes(Alumno a, Alumno b)
        {
            return -1 * OrdernarPorLejagoAsc(a,b);
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

        #region Polimorfismo

        public override string ToString()
        {
            return Mostrar();
        }

        #endregion
    }
}
