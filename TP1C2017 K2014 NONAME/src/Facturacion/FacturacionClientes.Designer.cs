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
            this.btnFacturacionPrevia = new System.Windows.Forms.Button();
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
            this.lblFechaInicioFacturacionPrevia = new System.Windows.Forms.Label();
            this.lblFechaInicioFactPreviaTexto = new System.Windows.Forms.Label();
            this.lblfechaFinFacturacionPrevia = new System.Windows.Forms.Label();
            this.lblFechaFinFacturacionPreviaTexto = new System.Windows.Forms.Label();
            this.lblFacturacionTotalPrevia = new System.Windows.Forms.Label();
            this.lblFactTotalPreviaTexto = new System.Windows.Forms.Label();
            this.tablaPreviaFacturacion = new System.Windows.Forms.DataGridView();
            this.lblDetalleDeFacturacion = new System.Windows.Forms.Label();
            this.lblPrevisualizacionFact = new System.Windows.Forms.Label();
            this.btnConfirmarFacturacion = new System.Windows.Forms.Button();
            this.lblNumeroFacturacion = new System.Windows.Forms.Label();
            this.lblNumeroFacturacionTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPreviaFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFacturacionPrevia
            // 
            this.btnFacturacionPrevia.BackColor = System.Drawing.SystemColors.Info;
            this.btnFacturacionPrevia.Location = new System.Drawing.Point(379, 75);
            this.btnFacturacionPrevia.Name = "btnFacturacionPrevia";
            this.btnFacturacionPrevia.Size = new System.Drawing.Size(187, 45);
            this.btnFacturacionPrevia.TabIndex = 0;
            this.btnFacturacionPrevia.Text = "Previsualizar Facturacion";
            this.btnFacturacionPrevia.UseVisualStyleBackColor = false;
            this.btnFacturacionPrevia.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(14, 91);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Clientes:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(67, 88);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(287, 21);
            this.cmbClientes.TabIndex = 3;
            // 
            // tablaFacturacion
            // 
            this.tablaFacturacion.AllowUserToAddRows = false;
            this.tablaFacturacion.AllowUserToDeleteRows = false;
            this.tablaFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFacturacion.Location = new System.Drawing.Point(12, 486);
            this.tablaFacturacion.Name = "tablaFacturacion";
            this.tablaFacturacion.ReadOnly = true;
            this.tablaFacturacion.Size = new System.Drawing.Size(720, 178);
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
            this.lblFacturacionClientesTexto.Location = new System.Drawing.Point(13, 709);
            this.lblFacturacionClientesTexto.Name = "lblFacturacionClientesTexto";
            this.lblFacturacionClientesTexto.Size = new System.Drawing.Size(203, 25);
            this.lblFacturacionClientesTexto.TabIndex = 6;
            this.lblFacturacionClientesTexto.Text = "Facturacion Total: $";
            // 
            // lblFacturacionTotal
            // 
            this.lblFacturacionTotal.AutoSize = true;
            this.lblFacturacionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacionTotal.Location = new System.Drawing.Point(217, 709);
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
            this.lblFechaFinFacturacion.Location = new System.Drawing.Point(661, 681);
            this.lblFechaFinFacturacion.Name = "lblFechaFinFacturacion";
            this.lblFechaFinFacturacion.Size = new System.Drawing.Size(0, 24);
            this.lblFechaFinFacturacion.TabIndex = 10;
            this.lblFechaFinFacturacion.Visible = false;
            // 
            // lblFechaFinFacturacionTexto
            // 
            this.lblFechaFinFacturacionTexto.AutoSize = true;
            this.lblFechaFinFacturacionTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinFacturacionTexto.Location = new System.Drawing.Point(452, 680);
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
            this.lblFechaInicioFacturacion.Location = new System.Drawing.Point(242, 680);
            this.lblFechaInicioFacturacion.Name = "lblFechaInicioFacturacion";
            this.lblFechaInicioFacturacion.Size = new System.Drawing.Size(0, 24);
            this.lblFechaInicioFacturacion.TabIndex = 12;
            this.lblFechaInicioFacturacion.Visible = false;
            // 
            // lblFechaInicioFacturacionTexto
            // 
            this.lblFechaInicioFacturacionTexto.AutoSize = true;
            this.lblFechaInicioFacturacionTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioFacturacionTexto.Location = new System.Drawing.Point(13, 680);
            this.lblFechaInicioFacturacionTexto.Name = "lblFechaInicioFacturacionTexto";
            this.lblFechaInicioFacturacionTexto.Size = new System.Drawing.Size(222, 24);
            this.lblFechaInicioFacturacionTexto.TabIndex = 11;
            this.lblFechaInicioFacturacionTexto.Text = "Fecha inicio Facturacion:";
            this.lblFechaInicioFacturacionTexto.Visible = false;
            // 
            // lblFechaInicioFacturacionPrevia
            // 
            this.lblFechaInicioFacturacionPrevia.AutoSize = true;
            this.lblFechaInicioFacturacionPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioFacturacionPrevia.Location = new System.Drawing.Point(248, 335);
            this.lblFechaInicioFacturacionPrevia.Name = "lblFechaInicioFacturacionPrevia";
            this.lblFechaInicioFacturacionPrevia.Size = new System.Drawing.Size(0, 24);
            this.lblFechaInicioFacturacionPrevia.TabIndex = 19;
            this.lblFechaInicioFacturacionPrevia.Visible = false;
            // 
            // lblFechaInicioFactPreviaTexto
            // 
            this.lblFechaInicioFactPreviaTexto.AutoSize = true;
            this.lblFechaInicioFactPreviaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioFactPreviaTexto.Location = new System.Drawing.Point(19, 335);
            this.lblFechaInicioFactPreviaTexto.Name = "lblFechaInicioFactPreviaTexto";
            this.lblFechaInicioFactPreviaTexto.Size = new System.Drawing.Size(222, 24);
            this.lblFechaInicioFactPreviaTexto.TabIndex = 18;
            this.lblFechaInicioFactPreviaTexto.Text = "Fecha inicio Facturacion:";
            this.lblFechaInicioFactPreviaTexto.Visible = false;
            // 
            // lblfechaFinFacturacionPrevia
            // 
            this.lblfechaFinFacturacionPrevia.AutoSize = true;
            this.lblfechaFinFacturacionPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaFinFacturacionPrevia.Location = new System.Drawing.Point(673, 336);
            this.lblfechaFinFacturacionPrevia.Name = "lblfechaFinFacturacionPrevia";
            this.lblfechaFinFacturacionPrevia.Size = new System.Drawing.Size(0, 24);
            this.lblfechaFinFacturacionPrevia.TabIndex = 17;
            this.lblfechaFinFacturacionPrevia.Visible = false;
            // 
            // lblFechaFinFacturacionPreviaTexto
            // 
            this.lblFechaFinFacturacionPreviaTexto.AutoSize = true;
            this.lblFechaFinFacturacionPreviaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinFacturacionPreviaTexto.Location = new System.Drawing.Point(464, 335);
            this.lblFechaFinFacturacionPreviaTexto.Name = "lblFechaFinFacturacionPreviaTexto";
            this.lblFechaFinFacturacionPreviaTexto.Size = new System.Drawing.Size(197, 24);
            this.lblFechaFinFacturacionPreviaTexto.TabIndex = 16;
            this.lblFechaFinFacturacionPreviaTexto.Text = "Fecha fin Facturacion:";
            this.lblFechaFinFacturacionPreviaTexto.Visible = false;
            // 
            // lblFacturacionTotalPrevia
            // 
            this.lblFacturacionTotalPrevia.AutoSize = true;
            this.lblFacturacionTotalPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacionTotalPrevia.Location = new System.Drawing.Point(224, 364);
            this.lblFacturacionTotalPrevia.Name = "lblFacturacionTotalPrevia";
            this.lblFacturacionTotalPrevia.Size = new System.Drawing.Size(24, 25);
            this.lblFacturacionTotalPrevia.TabIndex = 15;
            this.lblFacturacionTotalPrevia.Text = "0";
            // 
            // lblFactTotalPreviaTexto
            // 
            this.lblFactTotalPreviaTexto.AutoSize = true;
            this.lblFactTotalPreviaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactTotalPreviaTexto.Location = new System.Drawing.Point(20, 364);
            this.lblFactTotalPreviaTexto.Name = "lblFactTotalPreviaTexto";
            this.lblFactTotalPreviaTexto.Size = new System.Drawing.Size(203, 25);
            this.lblFactTotalPreviaTexto.TabIndex = 14;
            this.lblFactTotalPreviaTexto.Text = "Facturacion Total: $";
            // 
            // tablaPreviaFacturacion
            // 
            this.tablaPreviaFacturacion.AllowUserToAddRows = false;
            this.tablaPreviaFacturacion.AllowUserToDeleteRows = false;
            this.tablaPreviaFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPreviaFacturacion.Location = new System.Drawing.Point(18, 141);
            this.tablaPreviaFacturacion.Name = "tablaPreviaFacturacion";
            this.tablaPreviaFacturacion.ReadOnly = true;
            this.tablaPreviaFacturacion.Size = new System.Drawing.Size(714, 178);
            this.tablaPreviaFacturacion.TabIndex = 13;
            // 
            // lblDetalleDeFacturacion
            // 
            this.lblDetalleDeFacturacion.AutoSize = true;
            this.lblDetalleDeFacturacion.Location = new System.Drawing.Point(12, 467);
            this.lblDetalleDeFacturacion.Name = "lblDetalleDeFacturacion";
            this.lblDetalleDeFacturacion.Size = new System.Drawing.Size(111, 13);
            this.lblDetalleDeFacturacion.TabIndex = 20;
            this.lblDetalleDeFacturacion.Text = "Detalle de facturacion";
            // 
            // lblPrevisualizacionFact
            // 
            this.lblPrevisualizacionFact.AutoSize = true;
            this.lblPrevisualizacionFact.Location = new System.Drawing.Point(15, 125);
            this.lblPrevisualizacionFact.Name = "lblPrevisualizacionFact";
            this.lblPrevisualizacionFact.Size = new System.Drawing.Size(156, 13);
            this.lblPrevisualizacionFact.TabIndex = 21;
            this.lblPrevisualizacionFact.Text = "Previsualizacion De facturacion";
            // 
            // btnConfirmarFacturacion
            // 
            this.btnConfirmarFacturacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfirmarFacturacion.Location = new System.Drawing.Point(12, 413);
            this.btnConfirmarFacturacion.Name = "btnConfirmarFacturacion";
            this.btnConfirmarFacturacion.Size = new System.Drawing.Size(720, 35);
            this.btnConfirmarFacturacion.TabIndex = 22;
            this.btnConfirmarFacturacion.Text = "Confirmar Facturacion";
            this.btnConfirmarFacturacion.UseVisualStyleBackColor = false;
            this.btnConfirmarFacturacion.Click += new System.EventHandler(this.btnConfirmarFacturacion_Click);
            // 
            // lblNumeroFacturacion
            // 
            this.lblNumeroFacturacion.AutoSize = true;
            this.lblNumeroFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFacturacion.Location = new System.Drawing.Point(732, 709);
            this.lblNumeroFacturacion.Name = "lblNumeroFacturacion";
            this.lblNumeroFacturacion.Size = new System.Drawing.Size(24, 25);
            this.lblNumeroFacturacion.TabIndex = 24;
            this.lblNumeroFacturacion.Text = "0";
            // 
            // lblNumeroFacturacionTexto
            // 
            this.lblNumeroFacturacionTexto.AutoSize = true;
            this.lblNumeroFacturacionTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFacturacionTexto.Location = new System.Drawing.Point(451, 709);
            this.lblNumeroFacturacionTexto.Name = "lblNumeroFacturacionTexto";
            this.lblNumeroFacturacionTexto.Size = new System.Drawing.Size(286, 25);
            this.lblNumeroFacturacionTexto.TabIndex = 23;
            this.lblNumeroFacturacionTexto.Text = "El numero de facturacion es:";
            // 
            // FacturacionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 746);
            this.Controls.Add(this.lblNumeroFacturacion);
            this.Controls.Add(this.lblNumeroFacturacionTexto);
            this.Controls.Add(this.btnConfirmarFacturacion);
            this.Controls.Add(this.lblPrevisualizacionFact);
            this.Controls.Add(this.lblDetalleDeFacturacion);
            this.Controls.Add(this.lblFechaInicioFacturacionPrevia);
            this.Controls.Add(this.lblFechaInicioFactPreviaTexto);
            this.Controls.Add(this.lblfechaFinFacturacionPrevia);
            this.Controls.Add(this.lblFechaFinFacturacionPreviaTexto);
            this.Controls.Add(this.lblFacturacionTotalPrevia);
            this.Controls.Add(this.lblFactTotalPreviaTexto);
            this.Controls.Add(this.tablaPreviaFacturacion);
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
            this.Controls.Add(this.btnFacturacionPrevia);
            this.Name = "FacturacionClientes";
            this.Text = "Facturacion Cliente";
            this.Load += new System.EventHandler(this.FacturacionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPreviaFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacturacionPrevia;
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
        private System.Windows.Forms.Label lblFechaInicioFacturacionPrevia;
        private System.Windows.Forms.Label lblFechaInicioFactPreviaTexto;
        private System.Windows.Forms.Label lblfechaFinFacturacionPrevia;
        private System.Windows.Forms.Label lblFechaFinFacturacionPreviaTexto;
        private System.Windows.Forms.Label lblFacturacionTotalPrevia;
        private System.Windows.Forms.Label lblFactTotalPreviaTexto;
        private System.Windows.Forms.DataGridView tablaPreviaFacturacion;
        private System.Windows.Forms.Label lblDetalleDeFacturacion;
        private System.Windows.Forms.Label lblPrevisualizacionFact;
        private System.Windows.Forms.Button btnConfirmarFacturacion;
        private System.Windows.Forms.Label lblNumeroFacturacion;
        private System.Windows.Forms.Label lblNumeroFacturacionTexto;
    }
}