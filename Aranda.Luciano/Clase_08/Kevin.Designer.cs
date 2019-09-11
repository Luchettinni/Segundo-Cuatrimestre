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
            this.crearNuevaPaletaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.gpbPaleta.AutoSize = true;
            this.gpbPaleta.Controls.Add(this.lbxList1);
            this.gpbPaleta.Location = new System.Drawing.Point(12, 37);
            this.gpbPaleta.MaximumSize = new System.Drawing.Size(1366, 768);
            this.gpbPaleta.Name = "gpbPaleta";
            this.gpbPaleta.Size = new System.Drawing.Size(600, 393);
            this.gpbPaleta.TabIndex = 1;
            this.gpbPaleta.TabStop = false;
            this.gpbPaleta.Text = "Paleta";
            this.gpbPaleta.Visible = false;
            // 
            // lbxList1
            // 
            this.lbxList1.AccessibleName = "";
            this.lbxList1.FormattingEnabled = true;
            this.lbxList1.Location = new System.Drawing.Point(12, 19);
            this.lbxList1.Name = "lbxList1";
            this.lbxList1.Size = new System.Drawing.Size(577, 355);
            this.lbxList1.TabIndex = 0;
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
    }
}

