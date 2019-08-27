using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucchettinni;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno estudiante = new Alumno("Brenda", "Frias");
            LuccheTools.MessageColoured(estudiante.Mostrar(), ConsoleColor.Yellow);
            LuccheTools.MessagePause("Presiona una tecla para continuar...");
        }
    }
}
