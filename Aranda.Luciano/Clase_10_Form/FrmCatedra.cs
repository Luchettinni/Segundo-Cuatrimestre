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
                ListaDeAlumnos(listaDeAlumnos);
            } 
        }

        private void ListaDeAlumnos(List<Alumno> alumnos)
        {
            OrdenamientoDeListaDeAlumnos(cmbOrdenamiento.Text, alumnos);
            lbxAlumnos.Items.Clear();

            foreach (Alumno alumno in alumnos)
            {
                lbxAlumnos.Items.Add(Alumno.Mostrar(alumno));
            }
        }

        private void OrdenamientoDeListaDeAlumnos(string ordenamiento, List<Alumno> lista)
        {
            switch (ordenamiento)
            {
                case "LegajoAscendente":
                    {
                        lista.Sort(Alumno.OrdernarPorLejagoAsc);
                        break;
                    }
                case "LegajoDescendente":
                    {
                        lista.Sort(Alumno.OrdernarPorLejagoDes);
                        break;
                    }
                case "ApellidoAscendente":
                    {
                        lista.Sort(Alumno.OrdernarPorApellidoAsc);
                        break;
                    }
                case "ApellidoDescendente":
                    {
                        lista.Sort(Alumno.OrdernarPorApellidoDes);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void CmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaDeAlumnos(listaDeAlumnos);
        }
    }
}
