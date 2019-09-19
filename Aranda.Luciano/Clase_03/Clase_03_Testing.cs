using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuccheTools;

namespace Clase_03
{
    class Clase_03_Testing
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Luchetta", "Aranda", 42625103);

            LuccheTools.ConsoleTools.Message(persona.Mostrar() + "\n\n", ConsoleColor.Green);
            LuccheTools.ConsoleTools.PausaConMensaje();

            Console.Write("\n\nIngrese un numero: ");
            string numero = Console.ReadLine();

            if ( LuccheTools.ValidationTools.EsEntero( numero) )
            {
                LuccheTools.ConsoleTools.Message("\nEs Entero!\n\n", ConsoleColor.Green);
            }
            else if ( LuccheTools.ValidationTools.EsDecimal(numero))
            {
                LuccheTools.ConsoleTools.Message("\nEs Decimal!\n\n", ConsoleColor.Green);
            }
            else
            {
                LuccheTools.ConsoleTools.Message("\nNo es un numero...\n\n", ConsoleColor.Red);
            }

            Console.Write("\n");

            LuccheTools.ConsoleTools.PausaConMensaje();
        }
    }
}
