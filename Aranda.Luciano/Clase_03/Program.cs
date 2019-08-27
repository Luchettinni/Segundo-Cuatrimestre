using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucchettinni;

namespace Clase_03
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string aux;
            Persona miembro = new Persona("Luchetta", "Aranda", 42625103);

            aux = miembro.Mostrar();

            LuccheTools.MessageColoured( aux , ConsoleColor.Green);
            
            
            if (LuccheTools.StringValidateOnlyNumbers(aux) == 0)
            {
                LuccheTools.MessageColoured("Contiene no solo numeros, pero letras tambien", ConsoleColor.Green);
            }

            LuccheTools.MessagePause("Presione una tecla para continuar...");
        }
    }
}
