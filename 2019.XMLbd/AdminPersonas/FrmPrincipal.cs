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
        DataTable tablaPersonas;

        SqlConnection sqlConnection;

        SqlDataAdapter dataAdapter;

        public FrmPrincipal()
        {
            InitializeComponent();

            
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
            this.sqlConnection = new SqlConnection(Properties.Settings.Default.conexion);

            sqlConnection.Open();
            tablaPersonas = new DataTable("Personas");
            cargarDataTable();

            this.dataAdapter = new SqlDataAdapter("SELECT * FROM Personas", sqlConnection);
        }

        private void cargarDataTable()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT * FROM[personas_bd].[dbo].[personas]"; //"SELECT TOP 1000[id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]"; // con el "*" le digo que selecciones todas las columnas SELECT * FROM pesonas.
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            
            tablaPersonas.Load(dataReader);
            dataReader.Close();
            sqlConnection.Close();

            MessageBox.Show("Tabla cargada con exito");

            
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

        private void dataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorDataTable frmVisorDataTable = new frmVisorDataTable(tablaPersonas);
            frmVisorDataTable.Show();

            //this.dataAdapter.Fill(tablaPersonas);

            this.dataAdapter.InsertCommand = new SqlCommand("INSERT INTO Personas VALUES(@P1,@P2,@P3)",sqlConnection);
            this.dataAdapter.InsertCommand.Parameters.Add("@P1", SqlDbType.VarChar,50,"nombre");
            this.dataAdapter.InsertCommand.Parameters.Add("@P2", SqlDbType.VarChar, 50, "apellido");
            this.dataAdapter.InsertCommand.Parameters.Add("@P3", SqlDbType.Int,50,"edad");

            this.dataAdapter.UpdateCommand = new SqlCommand("UPDATE Personas SET nombre = @P1, apellido = @P2, edad = @P3 WHERE id = @P0",sqlConnection);
            this.dataAdapter.UpdateCommand.Parameters.Add("@P0", SqlDbType.Int, 50, "id");
            this.dataAdapter.UpdateCommand.Parameters.Add("@P1", SqlDbType.VarChar, 50, "nombre");
            this.dataAdapter.UpdateCommand.Parameters.Add("@P2", SqlDbType.VarChar, 50, "apellido");
            this.dataAdapter.UpdateCommand.Parameters.Add("@P3", SqlDbType.Int, 50, "edad");

            this.dataAdapter.DeleteCommand = new SqlCommand("DELETE FROM Personas WHERE id = @P0",sqlConnection);
            this.dataAdapter.DeleteCommand.Parameters.Add("@P0", SqlDbType.Int, 50, "id");

            this.dataAdapter.Update(tablaPersonas);
        }
    }
}
