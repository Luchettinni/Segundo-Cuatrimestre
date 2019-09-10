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
        public Paleta paleta = 5;

        public Kevin()
        {
            InitializeComponent();
            
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void crearNuevaPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbPaleta.Visible = true;
        }

        private void temperasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempera kevin = new frmTempera();
            kevin.ShowDialog();

            lbxList1.Items.Add( (string) kevin.MiTempera );
        }

        
    }
}
