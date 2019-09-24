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
    public partial class FrmCatedra : Form
    {
        private Catedra catedra = new Catedra();
        private List<AlumnoCalificado> listaDeAlumnos = new List<AlumnoCalificado>();
        
        public FrmCatedra()
        {
            InitializeComponent();
            foreach( ETipoOrdenamiento ordenamiento in Enum.GetValues(typeof(ETipoOrdenamiento)) )
            {
                this.cmbOrdenamiento.Items.Add(ordenamiento);
            }

            this.cmbOrdenamiento.SelectedIndex = 0;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno windowAlumno = new FrmAlumno();
            windowAlumno.ShowDialog();

            if (windowAlumno.DialogResult == DialogResult.OK )
            {
                if ( catedra + windowAlumno.Alumno )
                {
                    ActualizarListadoAlumnos(catedra, cmbOrdenamiento.Text);
                }
                
            } 
        }

        private void ActualizarListadoAlumnos(Catedra catedra, string ordenamiento)
        {
            switch (ordenamiento)
            {
                case "LegajoAscendente":
                    {
                        catedra.Alumnos.Sort(Alumno.OrdernarPorLejagoAsc);
                        break;
                    }
                case "LegajoDescendente":
                    {
                        catedra.Alumnos.Sort(Alumno.OrdernarPorLejagoDes);
                        break;
                    }
                case "ApellidoAscendente":
                    {
                        catedra.Alumnos.Sort(Alumno.OrdernarPorApellidoAsc);
                        break;
                    }
                case "ApellidoDescendente":
                    {
                        catedra.Alumnos.Sort(Alumno.OrdernarPorApellidoDes);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            lbxAlumnos.Items.Clear();

            foreach (Alumno alumno in this.catedra.Alumnos)
            {
                lbxAlumnos.Items.Add(alumno.ToString());
            }

            lbxAlumnosCalificados.Items.Clear();

            foreach (AlumnoCalificado alumno in this.listaDeAlumnos)
            {
                lbxAlumnosCalificados.Items.Add( alumno.ToString() );
            }

            //lbxAlumnos.Items.Add( catedra.ToString()); // re rancio esto xd
        }

        private void CmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListadoAlumnos(catedra, cmbOrdenamiento.Text);
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if ( lbxAlumnos.SelectedItem == null )
            {
                MessageBox.Show("Seleccione un alumno de la lista a modificar...");
            }
            else
            {



                frmAlumnoCalificado windowAlumnoCalificado = new frmAlumnoCalificado( catedra.Alumnos[lbxAlumnos.SelectedIndex] );
                windowAlumnoCalificado.ShowDialog();

                if (windowAlumnoCalificado.DialogResult == DialogResult.OK)
                {
                    if ( catedra - (catedra.Alumnos[lbxAlumnos.SelectedIndex]) )
                    {
                        
                        listaDeAlumnos.Add(windowAlumnoCalificado.AlumnoCalificado);
                        ActualizarListadoAlumnos(catedra, cmbOrdenamiento.Text);
                    }

                }
            }
        }
    }
}
