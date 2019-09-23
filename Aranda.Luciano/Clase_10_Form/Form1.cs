using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_10_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CatedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatedra windowCatedra = new FrmCatedra();
            windowCatedra.MdiParent = this;
            windowCatedra.Show();
        }
    }
}
