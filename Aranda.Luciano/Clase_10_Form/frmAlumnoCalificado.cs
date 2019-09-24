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

namespace Clase_10_Form
{
    public partial class frmAlumnoCalificado : FrmAlumno
    {

        AlumnoCalificado alumnoCalificado;

        public AlumnoCalificado AlumnoCalificado { get { return alumnoCalificado; } }

        public frmAlumnoCalificado(Alumno alumno) : base()
        {
            InitializeComponent();
            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;
            txtLegajo.Text = alumno.Legajo.ToString();
            cmbTipoDeExamen.Text = alumno.Examen.ToString();

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtLegajo.Enabled = false;
            cmbTipoDeExamen.Enabled = false;
        }

        protected override void BtnAceptar_Click(object sender, EventArgs e)
        {
            ETipoExamen examen = (ETipoExamen)cmbTipoDeExamen.SelectedItem;
            int legajo;
            double nota;

            if (!(int.TryParse(txtLegajo.Text, out legajo)))
            {
                MessageBox.Show("Ingrese un legajo valido (Numerico y no decimal)");
                this.DialogResult = DialogResult.Cancel;
            }

            if (!(double.TryParse(txtLegajo.Text, out nota)))
            {
                MessageBox.Show("Ingrese una nota valida (Decimal)");
                this.DialogResult = DialogResult.Cancel;
            }

            alumnoCalificado = new AlumnoCalificado(txtNombre.Text, txtApellido.Text, legajo, examen, nota);
        }
    }
}
