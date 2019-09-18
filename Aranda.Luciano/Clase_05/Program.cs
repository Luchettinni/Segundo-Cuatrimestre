using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_05.Entidades;
//using Lucchettinni;

namespace Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            Tinta tintita = new Tinta();

            Pluma plumita = new Pluma("tuvieja", tintita);
            b = (string)plumita;
           /* LuccheTools.MessageColoured( b, ConsoleColor.Blue );
            LuccheTools.MessagePause("Presione una tecla para continuar...");*/
        }
    }
}
