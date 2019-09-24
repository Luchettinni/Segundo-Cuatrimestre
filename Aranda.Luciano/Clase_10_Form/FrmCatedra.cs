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
        private List<Alumno> listaDeAlumnos = new List<Alumno>();
        
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
                listaDeAlumnos.Add(windowAlumno.Alumno);
                ActualizarListadoAlumnos(listaDeAlumnos, cmbOrdenamiento.Text);
            } 
        }

        private void ActualizarListadoAlumnos(List<Alumno> alumnos, string ordenamiento)
        {
            switch (ordenamiento)
            {
                case "LegajoAscendente":
                    {
                        alumnos.Sort(Alumno.OrdernarPorLejagoAsc);
                        break;
                    }
                case "LegajoDescendente":
                    {
                        alumnos.Sort(Alumno.OrdernarPorLejagoDes);
                        break;
                    }
                case "ApellidoAscendente":
                    {
                        alumnos.Sort(Alumno.OrdernarPorApellidoAsc);
                        break;
                    }
                case "ApellidoDescendente":
                    {
                        alumnos.Sort(Alumno.OrdernarPorApellidoDes);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            lbxAlumnos.Items.Clear();

            foreach (Alumno alumno in alumnos)
            {
                lbxAlumnos.Items.Add( Alumno.Mostrar(alumno) );
            }
        }

        private void CmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListadoAlumnos(listaDeAlumnos, cmbOrdenamiento.Text);
        }
    }
}
