using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class frmPersona : Form
    {
        private Persona miPersona;

        public Persona Persona
        {
            get { return this.miPersona; }
            
        }

        public frmPersona()
        {
            InitializeComponent();
        }

        public frmPersona(Persona persona):this()
        {
            this.txtApellido.Text = persona.apellido;
            this.txtNombre.Text = persona.nombre;
            this.txtEdad.Text = persona.edad.ToString();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                miPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtEdad.Text));
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                this.DialogResult = DialogResult.Cancel;
            }

            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
