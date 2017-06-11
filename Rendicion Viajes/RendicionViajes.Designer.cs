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
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.lblChofer = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRendir = new System.Windows.Forms.Button();
            this.tablaRendicion = new System.Windows.Forms.DataGridView();
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
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(422, 67);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(100, 20);
            this.txtChofer.TabIndex = 3;
            // 
            // lblChofer
            // 
            this.lblChofer.Location = new System.Drawing.Point(347, 70);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(69, 23);
            this.lblChofer.TabIndex = 2;
            this.lblChofer.Text = "Chofer: ";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(648, 67);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(100, 20);
            this.txtTurno.TabIndex = 6;
            // 
            // lblTurno
            // 
            this.lblTurno.Location = new System.Drawing.Point(581, 70);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(61, 23);
            this.lblTurno.TabIndex = 5;
            this.lblTurno.Text = "Turno: ";
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Location = new System.Drawing.Point(126, 117);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(100, 20);
            this.txtImporteTotal.TabIndex = 8;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.Location = new System.Drawing.Point(29, 120);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(100, 23);
            this.lblImporteTotal.TabIndex = 7;
            this.lblImporteTotal.Text = "Importe a rendir: ";
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
            this.btnRendir.Location = new System.Drawing.Point(385, 130);
            this.btnRendir.Name = "btnRendir";
            this.btnRendir.Size = new System.Drawing.Size(100, 40);
            this.btnRendir.TabIndex = 9;
            this.btnRendir.Text = "Rendir";
            this.btnRendir.Click += new System.EventHandler(this.btnRendir_Click);
            // 
            // tablaRendicion
            // 
            this.tablaRendicion.Location = new System.Drawing.Point(12, 202);
            this.tablaRendicion.Name = "tablaRendicion";
            this.tablaRendicion.Size = new System.Drawing.Size(842, 345);
            this.tablaRendicion.TabIndex = 10;
            // 
            // RendicionViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 558);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.selectorFecha);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.txtChofer);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.lblImporteTotal);
            this.Controls.Add(this.txtImporteTotal);
            this.Controls.Add(this.btnRendir);
            this.Controls.Add(this.tablaRendicion);
            this.Name = "RendicionViajes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaRendicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DateTimePicker selectorFecha;
        protected System.Windows.Forms.Label lblFecha;
        protected System.Windows.Forms.TextBox txtChofer;
        protected System.Windows.Forms.Label lblChofer;
        protected System.Windows.Forms.TextBox txtTurno;
        protected System.Windows.Forms.Label lblTurno;
        protected System.Windows.Forms.TextBox txtImporteTotal;
        protected System.Windows.Forms.Label lblImporteTotal;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Button btnRendir;
        protected System.Windows.Forms.DataGridView tablaRendicion;
    }
}