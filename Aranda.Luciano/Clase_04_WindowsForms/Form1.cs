using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase.Entidades;

namespace Clase_04_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int entero = int.Parse(this.txtEntero.Text);
            DateTime fecha = Convert.ToDateTime(this.txtFecha.Text);
            string cadena = this.txtCadena.Text;

            Cosa data = new Cosa(cadena, fecha, entero);

            

            LogBox.Items.Add(data.Mostrar());
            LogBox.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            Cosa data = new Cosa("kevin", DateTime.Now, 500 );
            txtEntero.Text = data.entero.ToString();
            txtFecha.Text = data.fecha.ToString();
            txtCadena.Text = data.cadena;
        }
    }
}
