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
            this.lblFacturacionClientesTexto = new System.Windows.Forms.Label();
            this.lblFacturacionTotal = new System.Windows.Forms.Label();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.lblFechaFinFacturacion = new System.Windows.Forms.Label();
            this.lblFechaFinFacturacionTexto = new System.Windows.Forms.Label();
            this.lblFechaInicioFacturacion = new System.Windows.Forms.Label();
            this.lblFechaInicioFacturacionTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(378, 88);
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
            this.lblCliente.Location = new System.Drawing.Point(14, 115);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Clientes:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(67, 112);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(287, 21);
            this.cmbClientes.TabIndex = 3;
            // 
            // tablaFacturacion
            // 
            this.tablaFacturacion.AllowUserToAddRows = false;
            this.tablaFacturacion.AllowUserToDeleteRows = false;
            this.tablaFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFacturacion.Location = new System.Drawing.Point(12, 170);
            this.tablaFacturacion.Name = "tablaFacturacion";
            this.tablaFacturacion.ReadOnly = true;
            this.tablaFacturacion.Size = new System.Drawing.Size(342, 178);
            this.tablaFacturacion.TabIndex = 4;
            // 
            // lblFacturacionCliente
            // 
            this.lblFacturacionCliente.AutoSize = true;
            this.lblFacturacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacionCliente.Location = new System.Drawing.Point(205, 13);
            this.lblFacturacionCliente.Name = "lblFacturacionCliente";
            this.lblFacturacionCliente.Size = new System.Drawing.Size(178, 24);
            this.lblFacturacionCliente.TabIndex = 5;
            this.lblFacturacionCliente.Text = "Facturacion clientes";
            // 
            // lblFacturacionClientesTexto
            // 
            this.lblFacturacionClientesTexto.AutoSize = true;
            this.lblFacturacionClientesTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacionClientesTexto.Location = new System.Drawing.Point(11, 454);
            this.lblFacturacionClientesTexto.Name = "lblFacturacionClientesTexto";
            this.lblFacturacionClientesTexto.Size = new System.Drawing.Size(203, 25);
            this.lblFacturacionClientesTexto.TabIndex = 6;
            this.lblFacturacionClientesTexto.Text = "Facturacion Total: $";
            // 
            // lblFacturacionTotal
            // 
            this.lblFacturacionTotal.AutoSize = true;
            this.lblFacturacionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacionTotal.Location = new System.Drawing.Point(215, 454);
            this.lblFacturacionTotal.Name = "lblFacturacionTotal";
            this.lblFacturacionTotal.Size = new System.Drawing.Size(24, 25);
            this.lblFacturacionTotal.TabIndex = 7;
            this.lblFacturacionTotal.Text = "0";
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAclaracion.Location = new System.Drawing.Point(9, 48);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(594, 16);
            this.lblAclaracion.TabIndex = 8;
            this.lblAclaracion.Text = "Se generara la factura del mes en curso para el cliente seleccionado, hasta la fe" +
    "cha del dia de hoy";
            // 
            // lblFechaFinFacturacion
            // 
            this.lblFechaFinFacturacion.AutoSize = true;
            this.lblFechaFinFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinFacturacion.Location = new System.Drawing.Point(221, 417);
            this.lblFechaFinFacturacion.Name = "lblFechaFinFacturacion";
            this.lblFechaFinFacturacion.Size = new System.Drawing.Size(0, 24);
            this.lblFechaFinFacturacion.TabIndex = 10;
            this.lblFechaFinFacturacion.Visible = false;
            // 
            // lblFechaFinFacturacionTexto
            // 
            this.lblFechaFinFacturacionTexto.AutoSize = true;
            this.lblFechaFinFacturacionTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinFacturacionTexto.Location = new System.Drawing.Point(12, 416);
            this.lblFechaFinFacturacionTexto.Name = "lblFechaFinFacturacionTexto";
            this.lblFechaFinFacturacionTexto.Size = new System.Drawing.Size(197, 24);
            this.lblFechaFinFacturacionTexto.TabIndex = 9;
            this.lblFechaFinFacturacionTexto.Text = "Fecha fin Facturacion:";
            this.lblFechaFinFacturacionTexto.Visible = false;
            // 
            // lblFechaInicioFacturacion
            // 
            this.lblFechaInicioFacturacion.AutoSize = true;
            this.lblFechaInicioFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioFacturacion.Location = new System.Drawing.Point(240, 377);
            this.lblFechaInicioFacturacion.Name = "lblFechaInicioFacturacion";
            this.lblFechaInicioFacturacion.Size = new System.Drawing.Size(0, 24);
            this.lblFechaInicioFacturacion.TabIndex = 12;
            this.lblFechaInicioFacturacion.Visible = false;
            // 
            // lblFechaInicioFacturacionTexto
            // 
            this.lblFechaInicioFacturacionTexto.AutoSize = true;
            this.lblFechaInicioFacturacionTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioFacturacionTexto.Location = new System.Drawing.Point(11, 377);
            this.lblFechaInicioFacturacionTexto.Name = "lblFechaInicioFacturacionTexto";
            this.lblFechaInicioFacturacionTexto.Size = new System.Drawing.Size(222, 24);
            this.lblFechaInicioFacturacionTexto.TabIndex = 11;
            this.lblFechaInicioFacturacionTexto.Text = "Fecha inicio Facturacion:";
            this.lblFechaInicioFacturacionTexto.Visible = false;
            // 
            // FacturacionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 499);
            this.Controls.Add(this.lblFechaInicioFacturacion);
            this.Controls.Add(this.lblFechaInicioFacturacionTexto);
            this.Controls.Add(this.lblFechaFinFacturacion);
            this.Controls.Add(this.lblFechaFinFacturacionTexto);
            this.Controls.Add(this.lblAclaracion);
            this.Controls.Add(this.lblFacturacionTotal);
            this.Controls.Add(this.lblFacturacionClientesTexto);
            this.Controls.Add(this.lblFacturacionCliente);
            this.Controls.Add(this.tablaFacturacion);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnFacturacion);
            this.Name = "FacturacionClientes";
            this.Text = "Facturacion Cliente";
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
        private System.Windows.Forms.Label lblFacturacionClientesTexto;
        private System.Windows.Forms.Label lblFacturacionTotal;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.Label lblFechaFinFacturacion;
        private System.Windows.Forms.Label lblFechaFinFacturacionTexto;
        private System.Windows.Forms.Label lblFechaInicioFacturacion;
        private System.Windows.Forms.Label lblFechaInicioFacturacionTexto;
    }
}