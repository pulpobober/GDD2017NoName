namespace UberFrba.Abm_Automovil
{
    partial class ModificacionAutomovil
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
            this.btnModificacion = new System.Windows.Forms.Button();
            this.ckbHabilitado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // selectMarca
            // 
            this.selectMarca.Items.AddRange(new object[] {
            "Fiat",
            "Peugeot",
            "Ford",
            "Renault",
            "Volkswagen",
            "Chevrolet",
            "Fiat",
            "Peugeot",
            "Ford",
            "Renault",
            "Volkswagen",
            "Chevrolet",
            "Fiat",
            "Peugeot",
            "Ford",
            "Renault",
            "Volkswagen",
            "Chevrolet",
            "Fiat",
            "Peugeot",
            "Ford",
            "Renault",
            "Volkswagen",
            "Chevrolet",
            "Fiat",
            "Peugeot",
            "Ford",
            "Renault",
            "Volkswagen",
            "Chevrolet",
            "Fiat",
            "Peugeot",
            "Ford",
            "Renault",
            "Volkswagen",
            "Chevrolet"});
            this.selectMarca.Location = new System.Drawing.Point(188, 188);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(30, 19);
            this.lblTitulo.Size = new System.Drawing.Size(367, 37);
            this.lblTitulo.Text = "Modificacion Automovil";
            // 
            // cmbTurno
            // 
            this.cmbTurno.Items.AddRange(new object[] {
            "Turno Mañna",
            "Turno Tarde",
            "Turno Noche",
            "Turno Mañna",
            "Turno Tarde",
            "Turno Noche",
            "Turno Mañna",
            "Turno Tarde",
            "Turno Noche",
            "Turno Mañna",
            "Turno Tarde",
            "Turno Noche",
            "Turno Mañna",
            "Turno Tarde",
            "Turno Noche",
            "Turno Mañna",
            "Turno Tarde",
            "Turno Noche",
            "Turno Mañna",
            "Turno Tarde",
            "Turno Noche",
            "Turno Mañna",
            "Turno Tarde",
            "Turno Noche",
            "Turno Mañna",
            "Turno Tarde",
            "Turno Noche"});
            // 
            // cmbChofer
            // 
            this.cmbChofer.Items.AddRange(new object[] {
            "EDILIO Maldonado",
            "SILVERIO Campos",
            "DE FATIMA Rojas",
            "ATANASIO Ortiz",
            "ONAN Vargas",
            "CLAUS García",
            "RONALDO Jiménez",
            "THEO Maldonado",
            "MIKI Córdoba",
            "NICOLE Toro",
            "PAMPA Ledesma",
            "MATIAS Zúñiga",
            "ANICETO Fernández",
            "JUANA Alonso",
            "MARISA Ledesma",
            "DELFINA Valdéz",
            "ROSENDO Muñoz",
            "AGOSTINA Torres",
            "ISAAC Contreras",
            "KAPRIEL Escobar",
            "PERSEO Saavedra",
            "MEULÉN González",
            "HADA Correa",
            "GINA Álvarez",
            "ORIA Rojas",
            "ARÍSTIDES García",
            "MIRELLA López",
            "NAVILA Vera",
            "EDELINA Soto",
            "FARAS Franco",
            "FAVIO Sepúlveda",
            "MIGUEL Donoso",
            "AMAIKE Martínez",
            "INARA Farías",
            "NAHUEL Maidana",
            "BERTILDA Gutiérrez",
            "ZUAHIR Contreras",
            "MIGUEL Carvajal",
            "CHEVY Núñez",
            "IBERO Vera",
            "SELENA López"});
            this.cmbChofer.SelectedIndexChanged += new System.EventHandler(this.cmbChofer_SelectedIndexChanged);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(140, 353);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(98, 34);
            this.btnModificacion.TabIndex = 29;
            this.btnModificacion.Text = "Modificar";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // ckbHabilitado
            // 
            this.ckbHabilitado.AutoSize = true;
            this.ckbHabilitado.Location = new System.Drawing.Point(140, 321);
            this.ckbHabilitado.Name = "ckbHabilitado";
            this.ckbHabilitado.Size = new System.Drawing.Size(73, 17);
            this.ckbHabilitado.TabIndex = 31;
            this.ckbHabilitado.Text = "Habilitado";
            this.ckbHabilitado.UseVisualStyleBackColor = true;
            // 
            // ModificacionAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 399);
            this.Controls.Add(this.ckbHabilitado);
            this.Controls.Add(this.btnModificacion);
            this.Name = "ModificacionAutomovil";
            this.Load += new System.EventHandler(this.ModificacionAutomovil_Load);
            this.Controls.SetChildIndex(this.txtRodado, 0);
            this.Controls.SetChildIndex(this.txtLicencia, 0);
            this.Controls.SetChildIndex(this.lblRodado, 0);
            this.Controls.SetChildIndex(this.lblLicencia, 0);
            this.Controls.SetChildIndex(this.cmbChofer, 0);
            this.Controls.SetChildIndex(this.cmbTurno, 0);
            this.Controls.SetChildIndex(this.btnModificacion, 0);
            this.Controls.SetChildIndex(this.lblChofer, 0);
            this.Controls.SetChildIndex(this.lblTurno, 0);
            this.Controls.SetChildIndex(this.lblPatente, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.selectMarca, 0);
            this.Controls.SetChildIndex(this.txtPatente, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.ckbHabilitado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.CheckBox ckbHabilitado;
    }
}