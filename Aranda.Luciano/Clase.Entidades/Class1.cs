using System;

namespace Clase.Entidades
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        public string Mostrar()
        {
            return " " + this.entero.ToString().PadLeft(5) + " /// " + this.cadena.PadRight(10) + " /// " + this.fecha.ToString().PadRight(5);
        }

        public void establecerValor(int toSet)
        {
            this.entero = toSet;
        }

        public void establecerValor(string toSet)
        {
            this.cadena = toSet;
        }

        public void establecerValor(DateTime toSet)
        {
            this.fecha = toSet;
        }

        public Cosa ()
        {
            this.entero = -1;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(string toSet) : this()
        {
            this.cadena = toSet;
        }

        public Cosa(string toSet, DateTime toSetDate) : this(toSet)
        {
            this.fecha = toSetDate;
        }

        public Cosa(string toSet, DateTime toSetDate, int toSetInt) : this(toSet, toSetDate)
        {
            this.entero = toSetInt;
        }
    }
}
