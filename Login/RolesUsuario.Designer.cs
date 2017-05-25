namespace UberFrba.Login
{
    partial class RolesUsuario
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
            this.btnRol = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarRol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRol
            // 
            this.btnRol.Location = new System.Drawing.Point(157, 138);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(126, 39);
            this.btnRol.TabIndex = 0;
            this.btnRol.Text = "Seleccionar Rol";
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Items.AddRange(new object[] {
            "Administrador",
            "Chofer",
            "Cliente"});
            this.cmbRoles.Location = new System.Drawing.Point(42, 82);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(356, 28);
            this.cmbRoles.TabIndex = 1;
            // 
            // lblSeleccionarRol
            // 
            this.lblSeleccionarRol.AutoSize = true;
            this.lblSeleccionarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarRol.Location = new System.Drawing.Point(104, 31);
            this.lblSeleccionarRol.Name = "lblSeleccionarRol";
            this.lblSeleccionarRol.Size = new System.Drawing.Size(232, 31);
            this.lblSeleccionarRol.TabIndex = 2;
            this.lblSeleccionarRol.Text = "Seleccione un Rol";
            // 
            // RolesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 210);
            this.Controls.Add(this.lblSeleccionarRol);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.btnRol);
            this.Name = "RolesUsuario";
            this.Text = "RolesUsuario";
            this.Load += new System.EventHandler(this.RolesUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblSeleccionarRol;
    }
}