namespace Clase_08
{
    partial class Kevin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevaPaletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbPaleta = new System.Windows.Forms.GroupBox();
            this.lbxList1 = new System.Windows.Forms.ListBox();
            this.btnCargarTempera = new System.Windows.Forms.Button();
            this.btnPintar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gpbPaleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevaPaletaToolStripMenuItem});
            this.administraciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // crearNuevaPaletaToolStripMenuItem
            // 
            this.crearNuevaPaletaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.crearNuevaPaletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperasToolStripMenuItem});
            this.crearNuevaPaletaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.crearNuevaPaletaToolStripMenuItem.Name = "crearNuevaPaletaToolStripMenuItem";
            this.crearNuevaPaletaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.crearNuevaPaletaToolStripMenuItem.Text = "Crear nueva paleta";
            this.crearNuevaPaletaToolStripMenuItem.Click += new System.EventHandler(this.crearNuevaPaletaToolStripMenuItem_Click);
            // 
            // temperasToolStripMenuItem
            // 
            this.temperasToolStripMenuItem.AutoSize = false;
            this.temperasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.temperasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.temperasToolStripMenuItem.Name = "temperasToolStripMenuItem";
            this.temperasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temperasToolStripMenuItem.Text = "Temperas";
            this.temperasToolStripMenuItem.Click += new System.EventHandler(this.temperasToolStripMenuItem_Click);
            // 
            // gpbPaleta
            // 
            this.gpbPaleta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbPaleta.AutoSize = true;
            this.gpbPaleta.Controls.Add(this.btnModificar);
            this.gpbPaleta.Controls.Add(this.btnPintar);
            this.gpbPaleta.Controls.Add(this.btnCargarTempera);
            this.gpbPaleta.Controls.Add(this.lbxList1);
            this.gpbPaleta.Location = new System.Drawing.Point(12, 37);
            this.gpbPaleta.MaximumSize = new System.Drawing.Size(1366, 768);
            this.gpbPaleta.Name = "gpbPaleta";
            this.gpbPaleta.Size = new System.Drawing.Size(600, 396);
            this.gpbPaleta.TabIndex = 1;
            this.gpbPaleta.TabStop = false;
            this.gpbPaleta.Text = "Paleta";
            this.gpbPaleta.Visible = false;
            // 
            // lbxList1
            // 
            this.lbxList1.AccessibleName = "";
            this.lbxList1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbxList1.BackColor = System.Drawing.Color.Gray;
            this.lbxList1.ForeColor = System.Drawing.Color.White;
            this.lbxList1.FormattingEnabled = true;
            this.lbxList1.Location = new System.Drawing.Point(15, 74);
            this.lbxList1.Name = "lbxList1";
            this.lbxList1.Size = new System.Drawing.Size(569, 303);
            this.lbxList1.TabIndex = 0;
            // 
            // btnCargarTempera
            // 
            this.btnCargarTempera.BackColor = System.Drawing.Color.Crimson;
            this.btnCargarTempera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarTempera.Location = new System.Drawing.Point(15, 29);
            this.btnCargarTempera.Name = "btnCargarTempera";
            this.btnCargarTempera.Size = new System.Drawing.Size(92, 39);
            this.btnCargarTempera.TabIndex = 2;
            this.btnCargarTempera.Text = "Nueva Tempera";
            this.btnCargarTempera.UseVisualStyleBackColor = false;
            this.btnCargarTempera.Click += new System.EventHandler(this.btnCargarTempera_Click);
            // 
            // btnPintar
            // 
            this.btnPintar.BackColor = System.Drawing.Color.Crimson;
            this.btnPintar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPintar.Location = new System.Drawing.Point(113, 29);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(92, 39);
            this.btnPintar.TabIndex = 3;
            this.btnPintar.Text = "Quitar Tempera";
            this.btnPintar.UseVisualStyleBackColor = false;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Crimson;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(211, 29);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 39);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Kevin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.gpbPaleta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kevin";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbPaleta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevaPaletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperasToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbPaleta;
        private System.Windows.Forms.ListBox lbxList1;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.Button btnCargarTempera;
        private System.Windows.Forms.Button btnModificar;
    }
}

