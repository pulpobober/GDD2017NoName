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
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.selectHabilitado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            this.selectMarca.Location = new System.Drawing.Point(188, 188);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(30, 19);
            this.lblTitulo.Size = new System.Drawing.Size(367, 37);
            this.lblTitulo.Text = "Modificacion Automovil";
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(140, 292);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(98, 34);
            this.btnModificacion.TabIndex = 29;
            this.btnModificacion.Text = "Modificar";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.Location = new System.Drawing.Point(34, 255);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(58, 23);
            this.lblHabilitado.TabIndex = 30;
            this.lblHabilitado.Text = "Habilitado";
            // 
            // selectHabilitado
            // 
            this.selectHabilitado.DropDownWidth = 179;
            this.selectHabilitado.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.selectHabilitado.Location = new System.Drawing.Point(188, 255);
            this.selectHabilitado.Name = "selectHabilitado";
            this.selectHabilitado.Size = new System.Drawing.Size(171, 21);
            this.selectHabilitado.TabIndex = 1;
            // 
            // ModificacionAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 338);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.lblHabilitado);
            this.Controls.Add(this.selectHabilitado);
            this.Name = "ModificacionAutomovil";
            this.Controls.SetChildIndex(this.selectHabilitado, 0);
            this.Controls.SetChildIndex(this.lblHabilitado, 0);
            this.Controls.SetChildIndex(this.btnModificacion, 0);
            this.Controls.SetChildIndex(this.lblLicencia, 0);
            this.Controls.SetChildIndex(this.lblRodado, 0);
            this.Controls.SetChildIndex(this.lblChofer, 0);
            this.Controls.SetChildIndex(this.lblTurno, 0);
            this.Controls.SetChildIndex(this.lblPatente, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.selectMarca, 0);
            this.Controls.SetChildIndex(this.txtLicencia, 0);
            this.Controls.SetChildIndex(this.txtRodado, 0);
            this.Controls.SetChildIndex(this.txtChofer, 0);
            this.Controls.SetChildIndex(this.txtTurno, 0);
            this.Controls.SetChildIndex(this.txtPatente, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Label lblHabilitado;
        private System.Windows.Forms.ComboBox selectHabilitado;
    }
}