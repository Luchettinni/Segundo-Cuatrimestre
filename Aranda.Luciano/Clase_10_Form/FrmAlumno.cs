using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10.Entidades;
using LuccheTools;

namespace Clase_10_Form
{
    public partial class FrmAlumno : Form
    {
        private Alumno alumno;
        public Alumno Alumno { get { return alumno; } }

        public FrmAlumno()
        {
            InitializeComponent();

            foreach (ETipoExamen ordenamiento in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoDeExamen.Items.Add(ordenamiento);
            }

            this.cmbTipoDeExamen.SelectedIndex = 2;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            ETipoExamen examen = (ETipoExamen)cmbTipoDeExamen.SelectedItem;
            int legajo;

            if ( !(int.TryParse(txtLegajo.Text, out legajo)) )
            {
                MessageBox.Show("Ingrese un legajo valido (Numerico y no decimal)");
                this.DialogResult = DialogResult.Cancel;
            }

            alumno = new Alumno(txtNombre.Text, txtApellido.Text, legajo, examen);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
