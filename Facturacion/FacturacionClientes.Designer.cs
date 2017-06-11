namespace UberFrba.Facturacion
{
    partial class FacturacionClientes
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
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.tablaFacturacion = new System.Windows.Forms.DataGridView();
            this.lblFacturacionCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(378, 13);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(205, 66);
            this.btnFacturacion.TabIndex = 0;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 61);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Clientes:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(65, 58);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(287, 21);
            this.cmbClientes.TabIndex = 3;
            // 
            // tablaFacturacion
            // 
            this.tablaFacturacion.AllowUserToAddRows = false;
            this.tablaFacturacion.AllowUserToDeleteRows = false;
            this.tablaFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFacturacion.Location = new System.Drawing.Point(12, 107);
            this.tablaFacturacion.Name = "tablaFacturacion";
            this.tablaFacturacion.ReadOnly = true;
            this.tablaFacturacion.Size = new System.Drawing.Size(571, 168);
            this.tablaFacturacion.TabIndex = 4;
            // 
            // lblFacturacionCliente
            // 
            this.lblFacturacionCliente.AutoSize = true;
            this.lblFacturacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacionCliente.Location = new System.Drawing.Point(123, 13);
            this.lblFacturacionCliente.Name = "lblFacturacionCliente";
            this.lblFacturacionCliente.Size = new System.Drawing.Size(178, 24);
            this.lblFacturacionCliente.TabIndex = 5;
            this.lblFacturacionCliente.Text = "Facturacion clientes";
            // 
            // FacturacionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 357);
            this.Controls.Add(this.lblFacturacionCliente);
            this.Controls.Add(this.tablaFacturacion);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnFacturacion);
            this.Name = "FacturacionClientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FacturacionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.DataGridView tablaFacturacion;
        private System.Windows.Forms.Label lblFacturacionCliente;
    }
}