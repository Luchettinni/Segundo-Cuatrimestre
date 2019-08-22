using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class HolaMundo
    {
        static void Main()
        {
            int input;
            int max = 0;
            int min = 0;
            int contador = 0;
            int suma = 0;
            float promedio;

            do {
            Console.Write("ingrese un numero: ");
            input = int.Parse(Console.ReadLine());
            

            if (contador == 1)
            {
                max = input;
                min = input;
            }

            if ( input > max )
            {
                max = input;
            }

            if ( input < min )
            {
                min = input;
            }
            
            suma = input + suma;
            
            contador++;

            } while ( contador <= 4 );

            promedio = (float) suma / contador;
            Console.Write("El minimo es {0}, el maximo es {1} el promedio es {2}", min, max,promedio);

            Console.Write("\nPresione una tecla para continuar...");

            Console.ReadKey(true); // system("pause");

            //-------------------------------------------------------------------------------------------------------------
            string nombre = "Luccheta";
            string apellido = "Aranda";


            Console.Title = "(Ejercicio 01) Bienvenida ";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\nHola, mundo C#!\n\n");

            Console.Write(nombre);
            Console.Write(" " + apellido + "\n");
            Console.WriteLine("Nombre y apellido = {0} {1}", nombre, apellido); // {0} indice 1 de la lista a la derecha del string (lista de variables, osea "Nombre" y "apellido" son variables de la lista)
            Console.WriteLine("Apellido y nombre = {1} {0}", nombre, apellido);

            Console.Write("\nIngrese algo: ");
            input = int.Parse( Console.ReadLine());
            Console.WriteLine("\nInput = " + input);

            Console.Write("\nPresione una tecla para continuar...");

            Console.ReadKey(true); // system("pause");

        }
    }
}
