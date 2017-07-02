namespace UberFrba.Abm_Automovil
{
    partial class AltaAutomovil
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
            // selectMarca
            // 
            this.selectMarca.Location = new System.Drawing.Point(188, 180);
            // 
            // lblModelo
            // 
            this.lblModelo.Location = new System.Drawing.Point(37, 271);
            // 
            // lblPatente
            // 
            this.lblPatente.Location = new System.Drawing.Point(34, 210);
            // 
            // lblChofer
            // 
            this.lblChofer.Location = new System.Drawing.Point(37, 243);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(188, 271);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(237, 37);
            this.lblTitulo.Text = "Alta Automovil";
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(34, 180);
            this.lblMarca.Text = "Marca:";
            // 
            // checkListTurno
            // 
            this.checkListTurno.Size = new System.Drawing.Size(186, 79);
            // 
            // lblLicencia
            // 
            this.lblLicencia.Location = new System.Drawing.Point(34, 330);
            // 
            // lblRodado
            // 
            this.lblRodado.Location = new System.Drawing.Point(34, 305);
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(188, 323);
            // 
            // txtRodado
            // 
            this.txtRodado.Location = new System.Drawing.Point(188, 297);
            // 
            // cmbChofer
            // 
            this.cmbChofer.Location = new System.Drawing.Point(188, 235);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(164, 363);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 12;
            this.btnAlta.Text = "Alta";
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click_1);
            // 
            // AltaAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 443);
            this.Controls.Add(this.btnAlta);
            this.Name = "AltaAutomovil";
            this.Text = "AltaAutomovil";
            this.Load += new System.EventHandler(this.AltaAutomovil_Load);
            this.Controls.SetChildIndex(this.txtRodado, 0);
            this.Controls.SetChildIndex(this.txtLicencia, 0);
            this.Controls.SetChildIndex(this.lblRodado, 0);
            this.Controls.SetChildIndex(this.lblLicencia, 0);
            this.Controls.SetChildIndex(this.cmbChofer, 0);
            this.Controls.SetChildIndex(this.checkListTurno, 0);
            this.Controls.SetChildIndex(this.btnAlta, 0);
            this.Controls.SetChildIndex(this.lblChofer, 0);
            this.Controls.SetChildIndex(this.lblTurno, 0);
            this.Controls.SetChildIndex(this.lblPatente, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.selectMarca, 0);
            this.Controls.SetChildIndex(this.txtPatente, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlta;
    }
}