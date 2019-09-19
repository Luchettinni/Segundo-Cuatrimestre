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
        public static int Comparar(string cadenaOrigen, string cadenaObjetivo)
        {
            int retorno = -1;
            
            for ( int index = 0; index < cadenaOrigen.Length; index++ )
            {
                for (int objIndex = 0; objIndex < cadenaObjetivo.Length; objIndex++)
                {
                    if (cadenaOrigen[index] == cadenaObjetivo[objIndex])
                    {
                        retorno = 0;
                    }
                    else if (cadenaOrigen[index] > cadenaObjetivo[objIndex])
                    {
                        retorno = 1;
                        index = cadenaOrigen.Length;
                        break;
                    }
                    else if (cadenaOrigen[index] < cadenaObjetivo[objIndex])
                    {
                        retorno = -1;
                        index = cadenaOrigen.Length;
                        break;
                    }
                }
            }
            return retorno;
        }

        #endregion
    }
}
