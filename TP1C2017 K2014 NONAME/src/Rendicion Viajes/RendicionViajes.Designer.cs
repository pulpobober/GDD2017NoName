namespace UberFrba.Rendicion_Viajes
{
    partial class RendicionViajes
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.selectorFecha = new System.Windows.Forms.DateTimePicker();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRendir = new System.Windows.Forms.Button();
            this.tablaPreviaRendicion = new System.Windows.Forms.DataGridView();
            this.cmbChoferes = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblImporteTotalTexto = new System.Windows.Forms.Label();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.btnConfirmarRendicion = new System.Windows.Forms.Button();
            this.tablaRendicion = new System.Windows.Forms.DataGridView();
            this.lblDetalleRendicion = new System.Windows.Forms.Label();
            this.lblPrevisualizar = new System.Windows.Forms.Label();
            this.lblNumeroRendicion = new System.Windows.Forms.Label();
            this.lblNumeroRendicionTexto = new System.Windows.Forms.Label();
            this.lblPrevisualizarImporte = new System.Windows.Forms.Label();
            this.lblPrevisualizarImporteTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPreviaRendicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRendicion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(29, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 23);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha: ";
            // 
            // selectorFecha
            // 
            this.selectorFecha.Location = new System.Drawing.Point(101, 67);
            this.selectorFecha.Name = "selectorFecha";
            this.selectorFecha.Size = new System.Drawing.Size(200, 20);
            this.selectorFecha.TabIndex = 1;
            // 
            // lblChofer
            // 
            this.lblChofer.Location = new System.Drawing.Point(347, 70);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(69, 23);
            this.lblChofer.TabIndex = 2;
            this.lblChofer.Text = "Chofer: ";
            // 
            // lblTurno
            // 
            this.lblTurno.Location = new System.Drawing.Point(581, 70);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(46, 17);
            this.lblTurno.TabIndex = 5;
            this.lblTurno.Text = "Turno: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(324, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(230, 38);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Rendicion de Viajes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRendir
            // 
            this.btnRendir.BackColor = System.Drawing.SystemColors.Info;
            this.btnRendir.Location = new System.Drawing.Point(303, 96);
            this.btnRendir.Name = "btnRendir";
            this.btnRendir.Size = new System.Drawing.Size(265, 35);
            this.btnRendir.TabIndex = 9;
            this.btnRendir.Text = "Pevisualizar Rendicion";
            this.btnRendir.UseVisualStyleBackColor = false;
            this.btnRendir.Click += new System.EventHandler(this.btnRendir_Click);
            // 
            // tablaPreviaRendicion
            // 
            this.tablaPreviaRendicion.Location = new System.Drawing.Point(12, 153);
            this.tablaPreviaRendicion.Name = "tablaPreviaRendicion";
            this.tablaPreviaRendicion.Size = new System.Drawing.Size(904, 161);
            this.tablaPreviaRendicion.TabIndex = 10;
            // 
            // cmbChoferes
            // 
            this.cmbChoferes.FormattingEnabled = true;
            this.cmbChoferes.Location = new System.Drawing.Point(401, 66);
            this.cmbChoferes.Name = "cmbChoferes";
            this.cmbChoferes.Size = new System.Drawing.Size(153, 21);
            this.cmbChoferes.TabIndex = 11;
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(633, 66);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(104, 21);
            this.cmbTurno.TabIndex = 12;
            // 
            // lblImporteTotalTexto
            // 
            this.lblImporteTotalTexto.AutoSize = true;
            this.lblImporteTotalTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotalTexto.Location = new System.Drawing.Point(12, 611);
            this.lblImporteTotalTexto.Name = "lblImporteTotalTexto";
            this.lblImporteTotalTexto.Size = new System.Drawing.Size(355, 25);
            this.lblImporteTotalTexto.TabIndex = 13;
            this.lblImporteTotalTexto.Text = "El importe total de la rendicion es: $";
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(365, 611);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(24, 25);
            this.lblImporteTotal.TabIndex = 14;
            this.lblImporteTotal.Text = "0";
            // 
            // btnConfirmarRendicion
            // 
            this.btnConfirmarRendicion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmarRendicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarRendicion.Location = new System.Drawing.Point(12, 360);
            this.btnConfirmarRendicion.Name = "btnConfirmarRendicion";
            this.btnConfirmarRendicion.Size = new System.Drawing.Size(904, 35);
            this.btnConfirmarRendicion.TabIndex = 15;
            this.btnConfirmarRendicion.Text = "Confirmar Rendicion";
            this.btnConfirmarRendicion.UseVisualStyleBackColor = false;
            this.btnConfirmarRendicion.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablaRendicion
            // 
            this.tablaRendicion.AllowUserToAddRows = false;
            this.tablaRendicion.AllowUserToDeleteRows = false;
            this.tablaRendicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRendicion.Location = new System.Drawing.Point(12, 430);
            this.tablaRendicion.Name = "tablaRendicion";
            this.tablaRendicion.ReadOnly = true;
            this.tablaRendicion.Size = new System.Drawing.Size(904, 150);
            this.tablaRendicion.TabIndex = 16;
            // 
            // lblDetalleRendicion
            // 
            this.lblDetalleRendicion.AutoSize = true;
            this.lblDetalleRendicion.Location = new System.Drawing.Point(17, 411);
            this.lblDetalleRendicion.Name = "lblDetalleRendicion";
            this.lblDetalleRendicion.Size = new System.Drawing.Size(106, 13);
            this.lblDetalleRendicion.TabIndex = 17;
            this.lblDetalleRendicion.Text = "Detalle de Rendicion";
            this.lblDetalleRendicion.Click += new System.EventHandler(this.lblDetalleRendicion_Click);
            // 
            // lblPrevisualizar
            // 
            this.lblPrevisualizar.AutoSize = true;
            this.lblPrevisualizar.Location = new System.Drawing.Point(14, 137);
            this.lblPrevisualizar.Name = "lblPrevisualizar";
            this.lblPrevisualizar.Size = new System.Drawing.Size(117, 13);
            this.lblPrevisualizar.TabIndex = 18;
            this.lblPrevisualizar.Text = "Previsualizar Rendicion";
            // 
            // lblNumeroRendicion
            // 
            this.lblNumeroRendicion.AutoSize = true;
            this.lblNumeroRendicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRendicion.Location = new System.Drawing.Point(819, 611);
            this.lblNumeroRendicion.Name = "lblNumeroRendicion";
            this.lblNumeroRendicion.Size = new System.Drawing.Size(24, 25);
            this.lblNumeroRendicion.TabIndex = 20;
            this.lblNumeroRendicion.Text = "0";
            // 
            // lblNumeroRendicionTexto
            // 
            this.lblNumeroRendicionTexto.AutoSize = true;
            this.lblNumeroRendicionTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRendicionTexto.Location = new System.Drawing.Point(545, 611);
            this.lblNumeroRendicionTexto.Name = "lblNumeroRendicionTexto";
            this.lblNumeroRendicionTexto.Size = new System.Drawing.Size(268, 25);
            this.lblNumeroRendicionTexto.TabIndex = 19;
            this.lblNumeroRendicionTexto.Text = "El numero de rendicion es:";
            // 
            // lblPrevisualizarImporte
            // 
            this.lblPrevisualizarImporte.AutoSize = true;
            this.lblPrevisualizarImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevisualizarImporte.Location = new System.Drawing.Point(391, 317);
            this.lblPrevisualizarImporte.Name = "lblPrevisualizarImporte";
            this.lblPrevisualizarImporte.Size = new System.Drawing.Size(24, 25);
            this.lblPrevisualizarImporte.TabIndex = 22;
            this.lblPrevisualizarImporte.Text = "0";
            // 
            // lblPrevisualizarImporteTexto
            // 
            this.lblPrevisualizarImporteTexto.AutoSize = true;
            this.lblPrevisualizarImporteTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevisualizarImporteTexto.Location = new System.Drawing.Point(7, 317);
            this.lblPrevisualizarImporteTexto.Name = "lblPrevisualizarImporteTexto";
            this.lblPrevisualizarImporteTexto.Size = new System.Drawing.Size(379, 25);
            this.lblPrevisualizarImporteTexto.TabIndex = 21;
            this.lblPrevisualizarImporteTexto.Text = "El importe total de la rendicion seria: $";
            // 
            // RendicionViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 657);
            this.Controls.Add(this.lblPrevisualizarImporte);
            this.Controls.Add(this.lblPrevisualizarImporteTexto);
            this.Controls.Add(this.lblNumeroRendicion);
            this.Controls.Add(this.lblNumeroRendicionTexto);
            this.Controls.Add(this.lblPrevisualizar);
            this.Controls.Add(this.lblDetalleRendicion);
            this.Controls.Add(this.tablaRendicion);
            this.Controls.Add(this.btnConfirmarRendicion);
            this.Controls.Add(this.lblImporteTotal);
            this.Controls.Add(this.lblImporteTotalTexto);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbChoferes);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.selectorFecha);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.btnRendir);
            this.Controls.Add(this.tablaPreviaRendicion);
            this.Name = "RendicionViajes";
            this.Text = "Rendicion Viaje";
            this.Load += new System.EventHandler(this.RendicionViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPreviaRendicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRendicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DateTimePicker selectorFecha;
        protected System.Windows.Forms.Label lblFecha;
        protected System.Windows.Forms.Label lblChofer;
        protected System.Windows.Forms.Label lblTurno;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Button btnRendir;
        protected System.Windows.Forms.DataGridView tablaPreviaRendicion;
        private System.Windows.Forms.ComboBox cmbChoferes;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblImporteTotalTexto;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Button btnConfirmarRendicion;
        private System.Windows.Forms.DataGridView tablaRendicion;
        private System.Windows.Forms.Label lblDetalleRendicion;
        private System.Windows.Forms.Label lblPrevisualizar;
        private System.Windows.Forms.Label lblNumeroRendicion;
        private System.Windows.Forms.Label lblNumeroRendicionTexto;
        private System.Windows.Forms.Label lblPrevisualizarImporte;
        private System.Windows.Forms.Label lblPrevisualizarImporteTexto;
    }
}