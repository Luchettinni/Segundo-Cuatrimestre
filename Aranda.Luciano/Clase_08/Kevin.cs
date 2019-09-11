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
    public partial class Kevin : Form
    {
        public Paleta paleta;
        
        public Kevin()
        {

            InitializeComponent();
            temperasToolStripMenuItem.Enabled = false;
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void crearNuevaPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbxList1.Items.Clear();
            gpbPaleta.Visible = true;
            paleta = 5;
            btnCargarTempera.Enabled = false;
            temperasToolStripMenuItem.Enabled = true;
            

        }

        private void temperasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempera kevin = new frmTempera();
            kevin.ShowDialog();
            
            if ( kevin.DialogResult == DialogResult.OK )
            {
                // metodo getter para visualizar los colores de paleta
                // o una propiedad
                // o indexadores


                this.paleta += kevin.MiTempera;

                lbxList1.Items.Clear();
                for (int i = 0; i < paleta.getLenght; i++)
                {
                    if ( !Object.Equals(this.paleta[i] , null) )
                    {
                        lbxList1.Items.Add((string)this.paleta[i]);
                    }
                }

                crearNuevaPaletaToolStripMenuItem.Enabled = false;
                btnCargarTempera.Enabled = true;
            }
            
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            int index;

            for ( index = this.paleta.getLenght -1; index >= 0 ; index--)
            {
                if ( !Object.Equals( this.paleta[index] , null) )
                {
                    break;
                }
            }

            this.paleta[ index] = null;
            lbxList1.Items.Clear();
            for (int i = 0; i < paleta.getLenght; i++)
            {
                if (!Object.Equals(this.paleta[i], null))
                {
                    lbxList1.Items.Add((string)this.paleta[i]);
                }  
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = lbxList1.SelectedIndex;
            if ( !Object.Equals( index, -1) )
            {
                frmTempera newKevin = new frmTempera(this.paleta[index]);
                newKevin.ShowDialog();
                if (newKevin.DialogResult == DialogResult.OK)
                {

                    this.paleta += newKevin.MiTempera;

                    lbxList1.Items.Clear();
                    for (int i = 0; i < paleta.getLenght; i++)
                    {
                        if (!Object.Equals(this.paleta[i], null))
                        {
                            lbxList1.Items.Add((string)this.paleta[i]);
                        }
                    }
                }

            }
        }

        private void btnCargarTempera_Click(object sender, EventArgs e)
        {
            frmTempera kevin = new frmTempera();
            kevin.ShowDialog();

            if (kevin.DialogResult == DialogResult.OK)
            {

                this.paleta += kevin.MiTempera;

                lbxList1.Items.Clear();
                for (int i = 0; i < paleta.getLenght; i++)
                {
                    if (!Object.Equals(this.paleta[i], null))
                    {
                        lbxList1.Items.Add((string)this.paleta[i]);
                    }
                }
            }
        }
    }
}
