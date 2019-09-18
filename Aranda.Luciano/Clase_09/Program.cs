using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_09.Entidades;

namespace Clase_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Capitulo c1 = "Primer Capitulo";
            Capitulo c2 = "Segundo Capitulo";
            Capitulo c3 = "Tercer Capitulo";

            Console.WriteLine("Numero {0} // Titulo {1} // Paginas {2}\n", c1.Numero, c1.Titulo, c1.Paginas);
            Console.WriteLine("Numero {0} // Titulo {1} // Paginas {2}\n", c2.Numero, c2.Titulo, c2.Paginas);
            Console.WriteLine("Numero {0} // Titulo {1} // Paginas {2}\n", c3.Numero, c3.Titulo, c3.Paginas);

            Libro librito = new Libro("El kevin", "kevin");

            librito[1] = c1;
            librito[2] = c2;
            librito[3] = c3;

            Console.WriteLine( librito[1].Numero );

            Console.ReadKey();*/


            Libro miLibro = new Libro("C# al descubierto", "Joe Mayo");

            miLibro[0] = "Fundamentos Básicos de C#";
            miLibro[1] = "Cómo comenzar con C#";
            miLibro[2] = "Cómo escribir expresiones con C#";

            miLibro[0] = "Alcachofa";
            miLibro[2] = "Salamandra";

            miLibro[-1] = "Genero un índice erroneo";

            miLibro[5] = "Genero otro índice erroneo";

            Console.WriteLine("Libro:");

            Console.WriteLine("Titulo: {0}", miLibro.Titulo);

            Console.WriteLine("Autor: {0}", miLibro.Autor);

            Console.WriteLine("Cantidad de páginas: {0}", miLibro.CantiadDePaginas);

            for (int i = 0; i < miLibro.CantidadDeCapitulos; i++)

            {

                Console.WriteLine("Capitulo {0}: {1} {2}", miLibro[i].Numero, miLibro[i].Titulo, miLibro[i].Paginas);

            }

            Console.ReadLine();
        }
    }
}
