using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuccheTools
{
    /// <summary>
    /// Herramientas para una utilizacion mas practica de la consola.
    /// </summary>
    public class ConsoleTools
    {
        #region Console Tools: Message pause

        /// <summary>
        /// Muestra en pantalla "Presione una tecla para continuar..." a la espera de que el usuario ingrese alguna letra.
        /// </summary>
        public static void PausaConMensaje()
        {
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Muestra en pantalla un mensaje personalizado para luego quedar a la espera del ingreso de alguna tecla por parte del usuario.
        /// </summary>
        /// <param name="message">Mensaje a mostrar en pantalla.</param>
        public static void PausaConMensaje(string message)
        {
            Console.Write(message);
            Console.ReadKey(true);
        }

        /// <summary>
        /// Muestra en pantalla un mensaje personalizado y colorido para luego quedar a la espera del ingreso de alguna tecla por parte del usuario.
        /// </summary>
        /// <param name="message">Mensaje a mostrar en pantalla.</param>
        /// <param name="color">Color del texto.</param>
        public static void PausaConMensaje(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
            Console.ReadKey(true);
        }

        #endregion

        #region Console Tools: Color message

        /// <summary>
        /// TO COMPLETE.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="color"></param>
        public static void Message(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ResetColor();
        }

        #endregion
    }
}
