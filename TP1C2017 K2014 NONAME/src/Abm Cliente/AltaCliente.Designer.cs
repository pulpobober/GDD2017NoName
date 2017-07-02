namespace UberFrba.Abm_Cliente
{
    partial class AltaCliente
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
            this.btnAlta2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(180, 37);
            this.lblTitulo.Text = "Alta Cliente";
            // 
            // btnAlta2
            // 
            this.btnAlta2.Location = new System.Drawing.Point(100, 417);
            this.btnAlta2.Name = "btnAlta2";
            this.btnAlta2.Size = new System.Drawing.Size(193, 53);
            this.btnAlta2.TabIndex = 28;
            this.btnAlta2.Text = "Alta";
            this.btnAlta2.UseVisualStyleBackColor = true;
            this.btnAlta2.Click += new System.EventHandler(this.btnAlta2_Click);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 493);
            this.Controls.Add(this.btnAlta2);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            this.Controls.SetChildIndex(this.lblLocalidad, 0);
            this.Controls.SetChildIndex(this.lblPiso, 0);
            this.Controls.SetChildIndex(this.lblDepartamento, 0);
            this.Controls.SetChildIndex(this.txtPiso, 0);
            this.Controls.SetChildIndex(this.txtDepto, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtDNI, 0);
            this.Controls.SetChildIndex(this.txtMail, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.txtLocalidad, 0);
            this.Controls.SetChildIndex(this.txtCodPostal, 0);
            this.Controls.SetChildIndex(this.dateTimeNacimiento, 0);
            this.Controls.SetChildIndex(this.btnAlta2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlta2;
    }
}