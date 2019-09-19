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
        #region Validation Tools: Non-Dimentional Container
        /// <summary>
        /// Verifica si la cadena contiene por lo menos un caracter igual al especificado en el segundo parametro
        /// </summary>
        /// <param name="str">Es la cadena a verificar.</param>
        /// <param name="code">Es un caracter en valor ASCII</param>
        /// <returns>"Verdadero si contiene algun caracter igual al rango. "Falso" en caso contrario</returns>
        public static bool ContenedorDeCeroDimensiones(string str, int code)
        {
            bool esContenedor = false;

            if (str != null)
            {
                for (int indice = 0; indice < str.Length; indice++)
                {
                    if ( str[indice] == code )
                    {
                        esContenedor = true;
                        break;
                    }
                }
            }
            return esContenedor;
        }

        /// <summary>
        /// Verifica si la cadena contiene por lo menos un caracter igual al especificado en el segundo parametro
        /// </summary>
        /// <param name="str">Es la cadena a verificar.</param>
        /// <param name="code">Es un caracter en valor ASCII</param>
        /// <param name="cantidadContenida">Guarda la cantidad de caracteres que contenian dicho valor ASCII</param>
        /// <returns></returns>
        public static bool ContenedorDeCeroDimensiones(string str, int code, out int cantidadContenida)
        {
            bool esContenedor = false;
            cantidadContenida = 0;

            if( str != null )
            {
                for (int indice = 0; indice < str.Length; indice++)
                {
                    if ( str[indice] == code )
                    {
                        cantidadContenida++;
                    }
                }

                if (cantidadContenida > 0)
                {
                    esContenedor = true;
                }
            }

            return esContenedor;
        }

        #endregion

        #region Validation Tools: One-dimentional container

        /// <summary>
        /// //// Verifica si una cadena esta dentro de un rango de enteros pertenecientes a la tabla ASCII.
        /// <para>//// El rango es de "una dimension". osea entre un solo minimo y maximo.</para>
        /// </summary>
        /// <param name="str">Es la cadena a verificar.</param>
        /// <param name="min">Es el rango minimo.</param>
        /// <param name="max">Es el rango maximo.</param>
        /// <returns>"Verdadero si contiene algun caracter dentro del rango. "Falso" en caso contrario</returns>
        public static bool ContenedorDeUnaDimension(string str, int min, int max)
        {
            bool esContenedor = false;

            if( str != null )
            {
                for (int indice = 0; indice < str.Length; indice++)
                {
                    if (str[indice] >= min && str[indice] <= max)
                    {
                        esContenedor = true;
                        break;
                    }
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
        /// <param name="cantidadContenida">Guarda la cantidad de caracteres que contenian valores del rango</param>
        /// <returns>"Verdadero si contiene algun caracter dentro del rango. "Falso" en caso contrario</returns>
        public static bool ContenedorDeUnaDimension(string str, int min, int max, out int cantidadContenida)
        {
            bool esContenedor = false;
            cantidadContenida = 0;

            if( str != null )
            {
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
            }

            return esContenedor;
        }

        #endregion

        #region Validation Tools: Character limit

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

        #region Validation Tools: Allowed List
        public static bool ListaPermitida(string str, int optionsCuantity)
        {
            bool retorno = false;

            for ( int i = 1; i <= optionsCuantity; i++ )
            {
                if ( str == i.ToString()  )
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        #endregion

        #region  Validation Tools: Generic Validations

        public static bool ContieneNumeros(string str)
        {
            return ContenedorDeUnaDimension(str, 48, 57);
        }

        public static bool ContieneLetrasMayusculas(string str)
        {
            return ContenedorDeUnaDimension(str, 65, 90);
        }

        public static bool ContieneLetrasMinusculas(string str)
        {
            return ContenedorDeUnaDimension(str, 97, 122);
        }

        public static bool ContieneLetras(string str)
        {
            bool retorno = false;
            if( ContieneLetrasMayusculas(str) && ContieneLetrasMinusculas(str) )
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool ContieneEspacios(string str)
        {
            return ContenedorDeCeroDimensiones(str, 32);
        }

        public static bool EsEntero(string str)
        {
            int contiene = 0;
            bool retorno = false;
            if ( ContenedorDeUnaDimension(str, 48, 57, out contiene) && contiene == str.Length )
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool EsDecimal(string str)
        {
            int contiene = 0;
            bool retorno = false;

            if ( ContenedorDeUnaDimension(str, 48, 57, out contiene) && (contiene +1) == str.Length && ContenedorDeCeroDimensiones(str, 44) )
            {
                retorno = true;
            }
            return retorno;
        }

        #endregion

        // TO DO LIST: VALIDACIONES GENERICAS //// nueva clase: INPUTS
    }
}
