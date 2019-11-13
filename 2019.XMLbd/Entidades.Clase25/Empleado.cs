using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase25
{
    public class Empleado
    {

        #region Atributos

        public event LimiteSueldoDelegado limiteSueldoKevin;
        public event LimiteSueldoMejoradorDel limiteSueldoMejorado;

        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;

        #endregion

        #region Propiedades

        public string Nombre { get { return this.nombre; } set {this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public int Legajo { get {return this.legajo; } set {this.legajo = value; } }
        public double Sueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                if (value > 18000)
                {
                    this.limiteSueldoKevin(value, this);
                }
                else
                {
                    this.sueldo = value;
                }
            }
        }

        #endregion

        #region Constructores

        public Empleado(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        #endregion

        #region Metodos

        #endregion

        #region Sobrecargas y sobrescrituras

        public override string ToString()
        {
            return "Legajo: " + this.legajo.ToString().PadLeft(4,'0') + " Nombre: " + this.nombre.PadRight(15, '|') + " Apellido: " + this.apellido.PadRight(15, '|');
        }

        #endregion

    }
}
