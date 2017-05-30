namespace UberFrba.Abm_Rol
{
    partial class AltaRol
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(87, 25);
            this.lblTitulo.Text = "Alta Rol";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(139, 257);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(187, 49);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "Guardar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 318);
            this.Controls.Add(this.btnAlta);
            this.Name = "AltaRol";
            this.Text = "AltaRol";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtNombreRol, 0);
            this.Controls.SetChildIndex(this.checkListFuncionalidades, 0);
            this.Controls.SetChildIndex(this.lblFuncionalidades, 0);
            this.Controls.SetChildIndex(this.btnAlta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
    }
}