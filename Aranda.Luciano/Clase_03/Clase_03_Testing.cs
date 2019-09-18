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
        }
    }
}
