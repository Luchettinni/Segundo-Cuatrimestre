using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor setColor, string setMarca, int setCantidad)
        {
            color = setColor;
            marca = setMarca;
            cantidad = setCantidad;
        }

        private string Mostrar()
        {
            return "Color: " + this.color + " / Marca: " + this.marca + " / cantidad: " + this.cantidad;
        }

        public static implicit operator string(Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static bool operator ==(Tempera temperaA, Tempera temperaB)
        {
            if ( temperaA.marca == temperaB.marca && temperaA.color == temperaB.color )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tempera temperaA, Tempera temperaB)
        {
            if ( !(temperaA == temperaB) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Tempera operator +(Tempera temperaA, int cantidad)
        {
            temperaA.cantidad += cantidad;

            return temperaA;
        }

        public static Tempera operator +(Tempera temperaA, Tempera temperaB)
        {
            if (temperaA == temperaB)
            {
                temperaA = temperaA + temperaB.cantidad;
            }

            return temperaA;
        }
    }

    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaDeColores;

        private Paleta() : this(5) { }

        private Paleta(int setCantidad)
        {
            colores = new Tempera[setCantidad];
            cantidadMaximaDeColores = setCantidad;
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            string retorno = "";

            for ( int i = 0; i < this.cantidadMaximaDeColores; i++ )
            {
                 retorno = string.Concat( retorno, this.colores[i] + " \n" );
            }
            return retorno;
        }

        public static implicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static Paleta operator +(Paleta paletaA, Tempera temperaA)
        {
            int i = -1;

            for (int k = 0; k < paletaA.colores.Length; k++ )
            {
                if (Object.Equals(paletaA.colores[k], null))
                {
                    i = k;
                    break;
                }
            }
            
            if ( !Object.Equals(i, -1) )
            {
                paletaA.colores[i] = temperaA;
            }
            
            return paletaA;
        }
    }
}
