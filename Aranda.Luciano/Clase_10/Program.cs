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
            Alumno A2 = new Alumno("Luchito", "Aranda", 2, ETipoExamen.Primero);
            Alumno A3 = new Alumno("Thomas", "Alvarez", 3, ETipoExamen.Primero);
            Alumno A4 = new Alumno("Emmanuel", "Bazan", 4, ETipoExamen.Primero);
            Alumno A5 = new Alumno("Barbara", "Melana", 5, ETipoExamen.Primero);
            Alumno A6 = new Alumno("Alvaro", "Elena", 6, ETipoExamen.Primero);
            Alumno A7 = new Alumno("Luchito", "Cortese", 7, ETipoExamen.Primero);
            Alumno A8 = new Alumno("Brenda", "Frias", 8, ETipoExamen.Primero);

            // prueba para lucchetools

            Alumno A9 = new Alumno("Luchito2", "Aranda", 9, ETipoExamen.Primero);
            Alumno A10 = new Alumno("Alvaro", "Elena", 10, ETipoExamen.Primero);
            Alumno A11 = new Alumno("Luchito2", "ArandaA", 11, ETipoExamen.Primero);

            List<Alumno> alumnado = new List<Alumno>();

            alumnado.Add(A1);
            alumnado.Add(A2);
            alumnado.Add(A3);
            alumnado.Add(A4);
            alumnado.Add(A5);
            alumnado.Add(A6);
            alumnado.Add(A7);
            alumnado.Add(A8);
            alumnado.Add(A9);
            alumnado.Add(A10);
            alumnado.Add(A11);

            alumnado.Sort(Alumno.OrdernarPorApellidoAsc);
           

            foreach ( Alumno alumno in alumnado)
            {
                ConsoleTools.Message( Alumno.Mostrar(alumno) + "\n", ConsoleColor.Green );
            }

            ConsoleTools.MessageBarrier("-" , 80);
            alumnado.Sort(Alumno.OrdernarPorApellidoDes);

            foreach (Alumno alumno in alumnado)
            {
                ConsoleTools.Message(Alumno.Mostrar(alumno) + "\n", ConsoleColor.Green);
            }

            ConsoleTools.MessageBarrier("-", 80);
            alumnado.Sort(Alumno.OrdernarPorLejagoAsc);

            foreach (Alumno alumno in alumnado)
            {
                ConsoleTools.Message(Alumno.Mostrar(alumno) + "\n", ConsoleColor.Green);
            }

            ConsoleTools.MessageBarrier("-", 80);
            alumnado.Sort(Alumno.OrdernarPorLejagoDes);

            foreach (Alumno alumno in alumnado)
            {
                ConsoleTools.Message(Alumno.Mostrar(alumno) + "\n", ConsoleColor.Green);
            }

            ConsoleTools.MessageBarrier("-", 80);
            ConsoleTools.Message("A continuacion, se va agenerar una catedra...\n\n", ConsoleColor.DarkGray);

            Catedra c = new Catedra();

            if ( !(c + A1) )
            {
                ConsoleTools.Message("Este alumno ya existe en el sistema\n", ConsoleColor.Red);
            }
            else
            {
                ConsoleTools.Message("AÑADIDO: " + Alumno.Mostrar(c.Alumnos[0]) + "\n", ConsoleColor.Green);
            }

            if ( !(c + A1) )
            {
                ConsoleTools.Message("Este alumno ya existe en el sistema\n", ConsoleColor.Red);
            }
            else
            {
                ConsoleTools.Message("AÑADIDO: " + Alumno.Mostrar(c.Alumnos[0]) + "\n", ConsoleColor.Green);
            }

            if ( !(c + A2) )
            {
                ConsoleTools.Message("Este alumno ya existe en el sistema\n", ConsoleColor.Red);
            }
            else
            {
                ConsoleTools.Message("AÑADIDO: " + Alumno.Mostrar(c.Alumnos[1]) + "\n", ConsoleColor.Green);
            }

            ConsoleTools.MessageBarrier("-", 80);
            ConsoleTools.Message("LISTADO DE CATEDRA\n", ConsoleColor.DarkGray);
            foreach (Alumno alumno in c.Alumnos)
            {
                ConsoleTools.Message(Alumno.Mostrar(alumno) + "\n", ConsoleColor.Green);
            }
            ConsoleTools.MessageBarrier("-", 80);
            ConsoleTools.Message("Ahora se va a eliminar el elemento 2...\n", ConsoleColor.DarkGray);
            if ( !(c - A2) )
            {
                ConsoleTools.Message("Este alumno no existe en la catedra...\n", ConsoleColor.Red);
            }
            else
            {
                ConsoleTools.Message("ELIMINADO\n", ConsoleColor.Green);
            }

            ConsoleTools.MessageBarrier("-", 80);
            ConsoleTools.Message("LISTADO DE CATEDRA\n", ConsoleColor.DarkGray);
            foreach (Alumno alumno in c.Alumnos)
            {
                ConsoleTools.Message(Alumno.Mostrar(alumno) + "\n", ConsoleColor.Green);
            }

            ConsoleTools.MessageBarrier("-", 80);
            ConsoleTools.Message("A continuacion, se buscaran los siguientes alumnos en la catedra...\n", ConsoleColor.DarkGray);
            ConsoleTools.Message(Alumno.Mostrar(A1), ConsoleColor.Green);

            if ( (A1|c) == -1 )
            {
                ConsoleTools.Message(" NO EXISTE EN LA CATEDRA\n", ConsoleColor.Red);
            }
            else
            {
                ConsoleTools.Message(" EXISTE EN LA CATEDRA\n", ConsoleColor.Green);
            }
            ConsoleTools.Message(Alumno.Mostrar(A8), ConsoleColor.Green);
            if ((A8|c) == -1)
            {
                ConsoleTools.Message(" NO EXISTE EN LA CATEDRA\n", ConsoleColor.Red);
            }
            else
            {
                ConsoleTools.Message(" EXISTE EN LA CATEDRA\n", ConsoleColor.Green);
            }

            LuccheTools.ConsoleTools.PausaConMensaje();

        }
    }
}
