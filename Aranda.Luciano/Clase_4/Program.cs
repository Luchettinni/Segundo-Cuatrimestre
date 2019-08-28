using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase.Entidades;
using Lucchettinni;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosa = new Cosa();
            LuccheTools.MessageColoured(cosa.Mostrar(), ConsoleColor.Yellow);
            LuccheTools.MessageColoured("\n\n", ConsoleColor.Yellow);
            cosa.establecerValor("Tuvieja");
            cosa.establecerValor(56);
            cosa.establecerValor(DateTime.Now);
            LuccheTools.MessageColoured(cosa.Mostrar(), ConsoleColor.Yellow);
            LuccheTools.MessagePause("\nPausado...");
        }
    }
}
