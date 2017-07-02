namespace UberFrba.Abm_Chofer
{
    partial class ModificacionChofer
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
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(57, 24);
            this.lblTitulo.Size = new System.Drawing.Size(300, 37);
            this.lblTitulo.Text = "Modificacion Chofer";
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(96, 411);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(182, 56);
            this.btnModificacion.TabIndex = 29;
            this.btnModificacion.Text = "Modificar";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // ckbHabilitado
            // 
            this.ckbHabilitado.AutoSize = true;
            this.ckbHabilitado.Location = new System.Drawing.Point(151, 379);
            this.ckbHabilitado.Name = "ckbHabilitado";
            this.ckbHabilitado.Size = new System.Drawing.Size(73, 17);
            this.ckbHabilitado.TabIndex = 33;
            this.ckbHabilitado.Text = "Habilitado";
            this.ckbHabilitado.UseVisualStyleBackColor = true;
            // 
            // ModificacionChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 484);
            this.Controls.Add(this.ckbHabilitado);
            this.Controls.Add(this.btnModificacion);
            this.Name = "ModificacionChofer";
            this.Text = "ModificacionChofer";
            this.Controls.SetChildIndex(this.lblLocalidad, 0);
            this.Controls.SetChildIndex(this.lblPiso, 0);
            this.Controls.SetChildIndex(this.lblDepartamento, 0);
            this.Controls.SetChildIndex(this.txtPiso, 0);
            this.Controls.SetChildIndex(this.txtDepto, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtDNI, 0);
            this.Controls.SetChildIndex(this.txtMail, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.txtLocalidad, 0);
            this.Controls.SetChildIndex(this.dateTimeNacimiento, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnModificacion, 0);
            this.Controls.SetChildIndex(this.ckbHabilitado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.CheckBox ckbHabilitado;
    }
}