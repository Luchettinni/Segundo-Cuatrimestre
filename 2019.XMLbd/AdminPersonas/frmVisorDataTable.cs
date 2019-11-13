using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPersonas
{
    public partial class frmVisorDataTable : frmVisorPersona
    {
        DataTable dataTable;

        public frmVisorDataTable(DataTable dataTable)
        {
            this.InitializeComponent();
            this.dataTable = dataTable;

            this.ActualizarLista();
        }

        public DataTable Tabla { get { return this.dataTable; } }

        void ActualizarLista()
        {
            lstVisor.Items.Clear();

            foreach (DataRow row in this.dataTable.Rows)
            {
                if(row.RowState != DataRowState.Deleted)
                {
                    this.lstVisor.Items.Add($"{row[0]} - {row[1]} - {row[2]} - {row[3]}");
                }
            }
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {

            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                DataRow row = dataTable.NewRow();
                row["nombre"] = frm.Persona.nombre;
                row["apellido"] = frm.Persona.apellido;
                row["edad"] = frm.Persona.edad;
                dataTable.Rows.Add(row);

                this.ActualizarLista();
            }
        }

        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstVisor.SelectedIndex != -1)
            {
                DataRow row = dataTable.Rows[lstVisor.SelectedIndex];
                frmPersona frm = new frmPersona(row["nombre"].ToString(), row["apellido"].ToString(), int.Parse(row["edad"].ToString()));
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    row["nombre"] = frm.Persona.nombre;
                    row["apellido"] = frm.Persona.apellido;
                    row["edad"] = frm.Persona.edad;

                    this.ActualizarLista();
                }
            }
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstVisor.SelectedIndex != -1)
            {
                DataRow row = dataTable.Rows[lstVisor.SelectedIndex];
                row.Delete();

                this.ActualizarLista();
            }
        }
    }
}
