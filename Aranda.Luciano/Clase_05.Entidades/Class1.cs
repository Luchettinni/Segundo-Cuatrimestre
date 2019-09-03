using System;

namespace Clase_05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private EtipoTinta _tipo;

        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = EtipoTinta.Comun;
        }

        public Tinta( ConsoleColor color ) : this()
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color , EtipoTinta tinta) : this( color )
        {
            this._tipo = tinta;
        }

            private string Mostrar()
        {
           return "Color: " + this._color + "Tipo: " + this._tipo;
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator ==(Tinta tintaA, Tinta tintaB)
        {
            if( tintaA._color == tintaB._color && tintaA._tipo == tintaB._tipo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Tinta tintaA, ConsoleColor color) 
        {
            if (tintaA._color == color)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool operator !=(Tinta tintaA, ConsoleColor color)
        {
            return !(tintaA == color);
        }

        public static bool operator !=(Tinta tintaA, Tinta tintaB)
        {
            return !(tintaA == tintaB);
        }

        public static explicit operator string(Tinta tintaA)
        {
            return tintaA.Mostrar();
        }

    }

    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma ()
        {
            _marca = "sin marca";
            _tinta = null;
            _cantidad = 0;
        }

        public Pluma( string marca ) : this()
        {
            _marca = marca;
        }

        public Pluma(string marca, Tinta tintaA) : this(marca)
        {
            _tinta = tintaA;
        }

        public Pluma(string marca, Tinta tintaA, int cant) : this(marca, tintaA)
        {
            _cantidad = cant;
        }

        private string Mostrar()
        {
            return "marca: " + this._marca + " tinta: " + Tinta.Mostrar(this._tinta) + " cantidad: " + this._cantidad;
        }

        public static implicit operator string( Pluma pluma )
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Pluma tintaA, Tinta tintaB)
        {
            return (tintaA._tinta == tintaB);
        }

        public static bool operator !=(Pluma tintaA, Tinta tintaB)
        {
            return !(tintaA == tintaB);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if ( pluma._tinta != null && pluma == tinta && pluma._cantidad < 100)
            {
                pluma._cantidad++;
            }

            return pluma;
        }
    }
}
