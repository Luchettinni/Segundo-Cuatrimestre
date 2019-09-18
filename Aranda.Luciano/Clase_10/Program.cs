using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuccheTools;
using Clase_10.Entidades;

namespace Clase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno A1 = new Alumno("Kevin", "Ahumada", 1, ETipoExamen.Primero);
            Alumno A2 = new Alumno("Luchito", "Aranda", 1, ETipoExamen.Primero);
            Alumno A8 = new Alumno("Brenda", "Frias", 1, ETipoExamen.Primero);
            Alumno A3 = new Alumno("Thomas", "Alvarez", 1, ETipoExamen.Primero);
            Alumno A4 = new Alumno("Emmanuel", "Bazan", 1, ETipoExamen.Primero);
            Alumno A5 = new Alumno("Barbara", "Melana", 1, ETipoExamen.Primero);
            Alumno A6 = new Alumno("Alvaro", "Elena", 1, ETipoExamen.Primero);
            Alumno A7 = new Alumno("Luchito", "Cortese", 1, ETipoExamen.Primero);

            List<Alumno> alumnado = new List<Alumno>();

            alumnado.Add(A1);
            alumnado.Add(A2);
            alumnado.Add(A3);
            alumnado.Add(A4);
            alumnado.Add(A5);
            alumnado.Add(A6);
            alumnado.Add(A7);
            alumnado.Add(A8);

            alumnado.Sort(Alumno.OrdernarPorApellido);
           

            foreach ( Alumno alumno in alumnado)
            {
               LuccheTools.ConsoleTools.Message( Alumno.Mostrar(alumno) + "\n", ConsoleColor.Green );
            }

            LuccheTools.ConsoleTools.PausaConMensaje();

        }
    }
}
