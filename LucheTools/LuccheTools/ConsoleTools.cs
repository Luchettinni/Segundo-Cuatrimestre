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
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.ResetColor();
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

        #region Console Tools: message

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

        public static void MessageBarrier(string barrierType, int barrierLenght)
        {
            string retorno = "";

            for (int i = 0; i <= barrierLenght; i++)
            {
                retorno = string.Concat(retorno, barrierType);
            }

            Console.Write(retorno);
        }

        

        #endregion

        #region Console Tools: Generic application V1

        public static int GenericMenu(string firstTitle, string secondTitle, string[] options, string userInputMessage)
        {
            
            int opcion = 0;
            string respuesta;

            do
            {
                Console.Clear();
                ShowMenu(firstTitle, secondTitle, options, userInputMessage);
                respuesta = Console.ReadLine();

                if (ValidationTools.ListaPermitida(respuesta, options.Length))
                {
                    opcion = int.Parse(respuesta);
                }
                else
                {
                    Console.Write("||\n|| ");
                    ConsoleTools.Message("ERROR: Esa no es una opcion valida.\n", ConsoleColor.Red);
                    ConsoleTools.PausaConMensaje("||\n|| Presione una tecla para continuar...");
                    opcion = -1;
                }

            } while (opcion == -1);

            return opcion;
        }

        public static void AddTextLine(string text)
        {
            if (text != null)
            {
                Console.WriteLine("|| " + text);
            }
        }

        public static void AddTextLine(string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != null)
                {
                    Console.WriteLine("|| " + text[i]);
                }
            }
        }

        private static void ShowMenu(string firstTitle, string secondTitle, string[] options, string userInputMessage)
        {
            MessageBarrier("|", 80);
            Console.Write("\n|||||{0}|||||{1}|||||\n", firstTitle.PadRight(33, '|'), secondTitle.PadRight(33, '|'));
            MessageBarrier("|", 80);
            Console.Write("\n||- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            AddTextLine(options);
            Console.Write("||- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.Write("||\n|| {0}", userInputMessage);
        }

        #endregion

    }
}
