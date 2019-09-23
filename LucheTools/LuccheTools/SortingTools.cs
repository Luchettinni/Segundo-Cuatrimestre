using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuccheTools
{
    /// <summary>
    /// Herramientas de ordenamiento.
    /// </summary>
    public class SortingTools
    {
        #region Sorting Tools: string comparison

        /// <summary>
        /// Compara si la cadena "origen" es mayor o menor a la cadena "objetivo" mediante comparacion de codigo ASCII letra por letra.
        /// </summary>
        /// <param name="cadenaOrigen">Es la cadena que sera comparada con otra, el retorno se relaciona con esta estrictamente</param>
        /// <param name="cadenaObjetivo">La cadena "Original" se comparará contra esta</param>
        /// <returns>"1" = Cadena "Origen" es mayor a cadena "Objetivo". "-1" = es menor. "0" = son iguales. </returns>
        public static int CompararLetras(string cadenaOrigen, string cadenaObjetivo)
        {
            int retorno = 0;
            int index = 0;
            
            if ( cadenaOrigen != cadenaObjetivo )
            {
                while ( index != cadenaOrigen.Length && index != cadenaObjetivo.Length)
                {
                    if (cadenaOrigen[index] > cadenaObjetivo[index])
                    {
                        retorno = 1;
                        index = cadenaOrigen.Length;
                        break;
                    }
                    else if (cadenaOrigen[index] < cadenaObjetivo[index])
                    {
                        retorno = -1;
                        index = cadenaOrigen.Length;
                        break;
                    }
                    index++;
                }

                if (retorno == 0 && cadenaOrigen.Length > cadenaObjetivo.Length)
                {
                    retorno = 1;
                }
                else if  (retorno == 0 && cadenaOrigen.Length < cadenaObjetivo.Length )
                {
                    retorno = -1;
                }
            }

            return retorno;
        }

        #endregion
    }
}
