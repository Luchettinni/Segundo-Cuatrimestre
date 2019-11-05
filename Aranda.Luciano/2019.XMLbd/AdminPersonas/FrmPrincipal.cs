using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Entidades;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        SqlConnection sqlConnection;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
            this.sqlConnection = new SqlConnection(Properties.Settings.Default.conexion);

        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));

                OpenFileDialog path = new OpenFileDialog();
                path.ShowDialog();

                TextReader textReader = new StreamReader(path.FileName);

                this.lista = (List<Persona>)xml.Deserialize(textReader);

                textReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));

                SaveFileDialog path = new SaveFileDialog();
                path.ShowDialog();

                TextWriter textWriter = new StreamWriter(path.FileName);

                xml.Serialize(textWriter, this.lista);

                textWriter.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }   
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                MessageBox.Show("Base de Datos conectada con exito.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM[personas_bd].[dbo].[personas]"; //"SELECT TOP 1000[id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]"; // con el "*" le digo que selecciones todas las columnas SELECT * FROM pesonas.
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                this.lista.Clear();

                while (dataReader.Read() != false)
                {
                    Persona buffer = new Persona(
                        (string)dataReader["nombre"], (string)dataReader["apellido"], (int)dataReader["edad"]);
                    this.lista.Add(buffer);
                }
                MessageBox.Show("Base de Datos cargada con exito.");

                dataReader.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }
    }
}
