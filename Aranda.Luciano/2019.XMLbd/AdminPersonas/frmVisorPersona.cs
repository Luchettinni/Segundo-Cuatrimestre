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
    public partial class frmVisorPersona : Form
    {
        private List<Persona> lista;

        public frmVisorPersona()
        {
            InitializeComponent();
            this.lista = new List<Persona>();
        }

        public frmVisorPersona(List<Persona> l) 
        {
            InitializeComponent();
            this.lista = l;

            foreach (Persona p in this.lista)
            {
                this.lstVisor.Items.Add(p);
            }
        }

        public List<Persona> ListaFrm { get { return this.lista; } }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                this.lista.Add(frm.Persona);

                this.lstVisor.Items.Clear();

                foreach (Persona p in this.lista)
                {
                    this.lstVisor.Items.Add(p);
                }

                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conexion);
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "INSERT INTO Personas (nombre, apellido, edad) VALUES (@nombre, @apellido, @edad)"; //"SELECT TOP 1000[id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]"; // con el "*" le digo que selecciones todas las columnas SELECT * FROM pesonas.
                sqlCommand.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                sqlCommand.Parameters.AddWithValue("@edad", frm.Persona.edad);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if ( lstVisor.SelectedIndex != -1 )
            {
                Persona auxxd = (Persona)this.lstVisor.SelectedItem;
                frmPersona frm = new frmPersona( auxxd );
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    this.lista.RemoveAt(this.lstVisor.SelectedIndex);
                    this.lista.Insert(this.lstVisor.SelectedIndex, frm.Persona);

                    this.lstVisor.Items.Clear();

                    foreach (Persona p in this.lista)
                    {
                        this.lstVisor.Items.Add(p);
                    }

                    Persona aux = frm.Persona;

                    SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conexion);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "UPDATE Personas SET nombre = @nombre, apellido = @apellido, edad = @edad WHERE nombre = @destino";
                    sqlCommand.Parameters.AddWithValue("@nombre", aux.nombre);
                    sqlCommand.Parameters.AddWithValue("@apellido", aux.apellido);
                    sqlCommand.Parameters.AddWithValue("@edad", aux.edad);
                    sqlCommand.Parameters.AddWithValue("@destino", auxxd.nombre );
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            
            
            // falta xd

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ( this.lstVisor.SelectedIndex != -1 )
            {
                this.lista.RemoveAt(this.lstVisor.SelectedIndex);

                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conexion);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "DELETE FROM Personas WHERE apellido = @destino";
                sqlCommand.Parameters.AddWithValue("@destino", ((Persona) lstVisor.SelectedItem).apellido);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            this.lstVisor.Items.Clear();

            foreach ( Persona persona in this.lista )
            {
                this.lstVisor.Items.Add(persona);
            }
        }
    }
}
