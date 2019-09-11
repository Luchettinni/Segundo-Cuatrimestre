using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_08
{
    public partial class frmTempera : Form
    {
        Tempera tempera;
        public Tempera MiTempera
        {
            get { return this.tempera; }
        }

        public frmTempera()
        {
            InitializeComponent();


            foreach (ConsoleColor i in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(i);
            }

            this.comboBox1.SelectedItem = ConsoleColor.Black;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int entero;
            bool parseoExitoso = int.TryParse(txtCantidad.Text, out entero);

            if ( !parseoExitoso )
            {
                entero = 0;
            }

            ConsoleColor color = (ConsoleColor) this.comboBox1.SelectedItem;
            tempera = new Tempera(color, txtMarca.Text,  entero);
            this.DialogResult = DialogResult.OK;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
