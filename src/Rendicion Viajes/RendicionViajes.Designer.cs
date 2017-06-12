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
            this.tablaRendicion = new System.Windows.Forms.DataGridView();
            this.cmbChoferes = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblImporteTotalTexto = new System.Windows.Forms.Label();
            this.lblImporteTotal = new System.Windows.Forms.Label();
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
            this.lblTitulo.Location = new System.Drawing.Point(353, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 38);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Rendicion de Viajes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRendir
            // 
            this.btnRendir.Location = new System.Drawing.Point(261, 96);
            this.btnRendir.Name = "btnRendir";
            this.btnRendir.Size = new System.Drawing.Size(175, 68);
            this.btnRendir.TabIndex = 9;
            this.btnRendir.Text = "Rendir";
            this.btnRendir.Click += new System.EventHandler(this.btnRendir_Click);
            // 
            // tablaRendicion
            // 
            this.tablaRendicion.Location = new System.Drawing.Point(12, 170);
            this.tablaRendicion.Name = "tablaRendicion";
            this.tablaRendicion.Size = new System.Drawing.Size(696, 243);
            this.tablaRendicion.TabIndex = 10;
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
            this.lblImporteTotalTexto.Location = new System.Drawing.Point(13, 440);
            this.lblImporteTotalTexto.Name = "lblImporteTotalTexto";
            this.lblImporteTotalTexto.Size = new System.Drawing.Size(337, 25);
            this.lblImporteTotalTexto.TabIndex = 13;
            this.lblImporteTotalTexto.Text = "El importe total de la rendicion es:";
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(356, 440);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(70, 25);
            this.lblImporteTotal.TabIndex = 14;
            this.lblImporteTotal.Text = "label1";
            // 
            // RendicionViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 489);
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
            this.Controls.Add(this.tablaRendicion);
            this.Name = "RendicionViajes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RendicionViajes_Load);
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
        protected System.Windows.Forms.DataGridView tablaRendicion;
        private System.Windows.Forms.ComboBox cmbChoferes;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblImporteTotalTexto;
        private System.Windows.Forms.Label lblImporteTotal;
    }
}