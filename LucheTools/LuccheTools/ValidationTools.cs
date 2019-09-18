using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuccheTools
{
    /// <summary>
    /// Herramientas de validacion.
    /// </summary>
    public class ValidationTools
    {
        #region Validation Tools: One-dimentional container

        /// <summary>
        /// //// Verifica si una cadena esta dentro de un rango de enteros pertenecientes a la tabla ASCII.
        /// <para>//// El rango es de "una dimension". osea entre un solo minimo y maximo.</para>
        /// </summary>
        /// <param name="str">Es la cadena a verificar.</param>
        /// <param name="min">Es el rango minimo.</param>
        /// <param name="max">Es el rango maximo.</param>
        /// <returns></returns>
        public static bool ContenedorDeUnaDimension(string str, int min, int max)
        {
            bool esContenedor = false;

            for (int indice = 0; indice < str.Length; indice++)
            {
                if (str[indice] >= min && str[indice] <= max)
                {
                    esContenedor = true;
                    break;
                }
            }
            return esContenedor;
        }

        /// <summary>
        /// //// Verifica si una cadena esta dentro de un rango de enteros pertenecientes a la tabla ASCII.
        /// <para>//// El rango es de "una dimension". osea entre un solo minimo y maximo.</para>
        /// </summary>
        /// <param name="str">Es la cadena a verificar.</param>
        /// <param name="min">Es el rango minimo.</param>
        /// <param name="max">Es el rango maximo.</param>
        /// <param name="cantidadContenida">Guarda la cantidad de caracteres que estaban contenidas en el rango</param>
        public static bool ContenedorDeUnaDimension(string str, int min, int max, out int cantidadContenida)
        {
            bool esContenedor = false;
            cantidadContenida = 0;

            for (int indice = 0; indice < str.Length; indice++)
            {
                if (str[indice] >= min && str[indice] <= max)
                {
                    cantidadContenida++;
                }
            }

            if (cantidadContenida > 0)
            {
                esContenedor = true;
            }

            return esContenedor;
        }

        #endregion

        #region Validation Tools: Character limit.

        /// <summary>
        /// Valida si una cadena esta entre o sobre el maximo o por debajo del minimo impuesto.
        /// </summary>
        /// <param name="str">Es la cadena a validar</param>
        /// <param name="min">Minimo de caracteres que la cadena puede tener</param>
        /// <param name="max">Maximo de caracteres que la cadena puede tener</param>
        /// <returns>"1" = sobrepaso el maximo //// "-1" por debajo del minimo //// "0" dentro del rango.</returns>
        public static int LimiteDeCaracteres (string str, int min, int max)
        {
            int retorno;

            if ( min < 0 )
            {
                min = 0;
            }

            if ( str.Length > max )
            {
                retorno = 1;
            }
            else if ( str.Length < min )
            {
                retorno = -1;
            }
            else
            {
                retorno = 0;
            }

            return retorno;
        }

        #endregion

        /*#region  Validation Tools: Generic Validations

        #endregion*/

        // TO DO LIST: VALIDACIONES GENERICAS //// nueva clase: INPUTS
    }
}
