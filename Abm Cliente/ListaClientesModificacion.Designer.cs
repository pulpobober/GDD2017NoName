namespace UberFrba.Abm_Cliente
{
    partial class ListaClientesModificacion
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
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(162, 9);
            this.lblTitulo.Size = new System.Drawing.Size(292, 33);
            this.lblTitulo.Text = "Modificacion Clientes";
            // 
            // btnBuscar
            // 
            this.btnFiltrar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbSeleccionar
            // 
            this.lbSeleccionar.Location = new System.Drawing.Point(16, 208);
            this.lbSeleccionar.Size = new System.Drawing.Size(411, 25);
            this.lbSeleccionar.Text = "Seleccione el cliente que quiere modificar";
            // 
            // ListaClientesModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 449);
            this.Name = "ListaClientesModificacion";
            this.Text = "ListaClientesModificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}