using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase25;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("LISTADO DE EMPLEADOS");
            Empleado E1 = new Empleado("Juan", "Perez", 123);
            Empleado E2 = new Empleado("Luciano", "Aranda", 2);
            E1.limiteSueldoKevin += new LimiteSueldoDelegado(Mostrar);
            E2.limiteSueldoKevin += new LimiteSueldoDelegado(Mostrar);
            E1.Sueldo = 33000;
            E2.Sueldo = 2.50;



            Console.ReadKey(true);

        }

        public static void Mostrar(double sueldo, Empleado emp)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(emp.ToString() + " tiene sueldo que supera el limite (" + sueldo + ")");
            Console.ResetColor();
        }


    }
}
