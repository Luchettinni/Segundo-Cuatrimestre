namespace Clase_10_Form
{
    partial class FrmCatedra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxAlumnos = new System.Windows.Forms.GroupBox();
            this.cmbOrdenamiento = new System.Windows.Forms.ComboBox();
            this.lbxAlumnos = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbxAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.lbxAlumnosCalificados = new System.Windows.Forms.ListBox();
            this.gbxAlumnos.SuspendLayout();
            this.gbxAlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAlumnos
            // 
            this.gbxAlumnos.Controls.Add(this.cmbOrdenamiento);
            this.gbxAlumnos.Controls.Add(this.lbxAlumnos);
            this.gbxAlumnos.Controls.Add(this.btnModificar);
            this.gbxAlumnos.Controls.Add(this.btnCalificar);
            this.gbxAlumnos.Controls.Add(this.btnAgregar);
            this.gbxAlumnos.ForeColor = System.Drawing.Color.White;
            this.gbxAlumnos.Location = new System.Drawing.Point(12, 12);
            this.gbxAlumnos.Name = "gbxAlumnos";
            this.gbxAlumnos.Size = new System.Drawing.Size(600, 294);
            this.gbxAlumnos.TabIndex = 0;
            this.gbxAlumnos.TabStop = false;
            this.gbxAlumnos.Text = "Alumnos";
            // 
            // cmbOrdenamiento
            // 
            this.cmbOrdenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenamiento.FormattingEnabled = true;
            this.cmbOrdenamiento.Location = new System.Drawing.Point(35, 249);
            this.cmbOrdenamiento.Name = "cmbOrdenamiento";
            this.cmbOrdenamiento.Size = new System.Drawing.Size(530, 21);
            this.cmbOrdenamiento.TabIndex = 4;
            this.cmbOrdenamiento.TabStop = false;
            this.cmbOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.CmbOrdenamiento_SelectedIndexChanged);
            // 
            // lbxAlumnos
            // 
            this.lbxAlumnos.BackColor = System.Drawing.Color.LightGray;
            this.lbxAlumnos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbxAlumnos.FormattingEnabled = true;
            this.lbxAlumnos.Location = new System.Drawing.Point(35, 70);
            this.lbxAlumnos.Name = "lbxAlumnos";
            this.lbxAlumnos.Size = new System.Drawing.Size(530, 173);
            this.lbxAlumnos.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(393, 30);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(172, 25);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnCalificar
            // 
            this.btnCalificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalificar.FlatAppearance.BorderSize = 0;
            this.btnCalificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificar.Location = new System.Drawing.Point(212, 30);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(175, 25);
            this.btnCalificar.TabIndex = 1;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(35, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 25);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // gbxAlumnosCalificados
            // 
            this.gbxAlumnosCalificados.Controls.Add(this.lbxAlumnosCalificados);
            this.gbxAlumnosCalificados.ForeColor = System.Drawing.Color.White;
            this.gbxAlumnosCalificados.Location = new System.Drawing.Point(12, 312);
            this.gbxAlumnosCalificados.Name = "gbxAlumnosCalificados";
            this.gbxAlumnosCalificados.Size = new System.Drawing.Size(600, 288);
            this.gbxAlumnosCalificados.TabIndex = 5;
            this.gbxAlumnosCalificados.TabStop = false;
            this.gbxAlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // lbxAlumnosCalificados
            // 
            this.lbxAlumnosCalificados.BackColor = System.Drawing.Color.LightGray;
            this.lbxAlumnosCalificados.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbxAlumnosCalificados.FormattingEnabled = true;
            this.lbxAlumnosCalificados.Location = new System.Drawing.Point(35, 41);
            this.lbxAlumnosCalificados.Name = "lbxAlumnosCalificados";
            this.lbxAlumnosCalificados.Size = new System.Drawing.Size(530, 212);
            this.lbxAlumnosCalificados.TabIndex = 3;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(624, 610);
            this.Controls.Add(this.gbxAlumnosCalificados);
            this.Controls.Add(this.gbxAlumnos);
            this.Name = "FrmCatedra";
            this.Text = "FrmCatedra";
            this.gbxAlumnos.ResumeLayout(false);
            this.gbxAlumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAlumnos;
        private System.Windows.Forms.ComboBox cmbOrdenamiento;
        private System.Windows.Forms.ListBox lbxAlumnos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbxAlumnosCalificados;
        private System.Windows.Forms.ListBox lbxAlumnosCalificados;
    }
}