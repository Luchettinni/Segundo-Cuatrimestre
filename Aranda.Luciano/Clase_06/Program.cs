using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_06.Entidades;
using Lucchettinni;

namespace Clase_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera temperaAzul = new Tempera(ConsoleColor.Blue, "sharpie", 100);
            Tempera temperaRoja = new Tempera(ConsoleColor.Red, "la salada", 50);

            Paleta paleta = 2;
            
            paleta = paleta + temperaAzul;
            paleta = paleta + temperaRoja;
            /*LuccheTools.MessageColoured( temperaAzul , ConsoleColor.Gray);
            LuccheTools.MessagePause("presione una tecla para continuar...");
            LuccheTools.MessageColoured("\n\nA continuacion, se creara una paleta de colores.", ConsoleColor.Gray);
            LuccheTools.MessagePause("presione una tecla para continuar...\n\n");
            LuccheTools.MessageColoured( paleta, ConsoleColor.Green);
            LuccheTools.MessagePause("presione una tecla para continuar...");*/

            // hacer verificaciones de si son null las cosas
            // hacer un "buscar lugar libre"

            // hacer el operador - para quitar cantidad
            // - (paleta, tempera) : paleta

            // el operador pipe que retorna el indice de la tempera (pipe single)
            // pipe ( paleta,tempera) : int
        }
    }
}
