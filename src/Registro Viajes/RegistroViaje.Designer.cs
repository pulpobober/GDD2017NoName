namespace UberFrba.Registro_Viajes
{
    partial class RegistroViaje
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
            this.lblChofer = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutomovil = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblCantidadKilometros = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.cmbChoferes = new System.Windows.Forms.ComboBox();
            this.cmbAutomovil = new System.Windows.Forms.ComboBox();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.dataTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadKm = new System.Windows.Forms.TextBox();
            this.btnRegistrarViaje = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(18, 96);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(41, 13);
            this.lblChofer.TabIndex = 0;
            this.lblChofer.Text = "Chofer:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registro de viaje";
            // 
            // lblAutomovil
            // 
            this.lblAutomovil.AutoSize = true;
            this.lblAutomovil.Location = new System.Drawing.Point(9, 138);
            this.lblAutomovil.Name = "lblAutomovil";
            this.lblAutomovil.Size = new System.Drawing.Size(56, 13);
            this.lblAutomovil.TabIndex = 2;
            this.lblAutomovil.Text = "Automovil:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(243, 97);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "Turno:";
            // 
            // lblCantidadKilometros
            // 
            this.lblCantidadKilometros.AutoSize = true;
            this.lblCantidadKilometros.Location = new System.Drawing.Point(236, 143);
            this.lblCantidadKilometros.Name = "lblCantidadKilometros";
            this.lblCantidadKilometros.Size = new System.Drawing.Size(103, 13);
            this.lblCantidadKilometros.TabIndex = 4;
            this.lblCantidadKilometros.Text = "Cantidad Kilometros:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(13, 180);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(156, 13);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha y hora de inicio del viaje:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(12, 215);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(143, 13);
            this.lblFechaFin.TabIndex = 6;
            this.lblFechaFin.Text = "Fecha y hora de fin del viaje:";
            // 
            // cmbChoferes
            // 
            this.cmbChoferes.FormattingEnabled = true;
            this.cmbChoferes.Location = new System.Drawing.Point(65, 93);
            this.cmbChoferes.Name = "cmbChoferes";
            this.cmbChoferes.Size = new System.Drawing.Size(121, 21);
            this.cmbChoferes.TabIndex = 7;
            this.cmbChoferes.SelectedIndexChanged += new System.EventHandler(this.cmbChoferes_SelectedIndexChanged);
            // 
            // cmbAutomovil
            // 
            this.cmbAutomovil.FormattingEnabled = true;
            this.cmbAutomovil.Location = new System.Drawing.Point(71, 135);
            this.cmbAutomovil.Name = "cmbAutomovil";
            this.cmbAutomovil.Size = new System.Drawing.Size(121, 21);
            this.cmbAutomovil.TabIndex = 8;
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(290, 93);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(121, 21);
            this.cmbTurnos.TabIndex = 9;
            this.cmbTurnos.SelectedIndexChanged += new System.EventHandler(this.cmbTurnos_SelectedIndexChanged);
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeFin.Location = new System.Drawing.Point(175, 215);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFin.TabIndex = 10;
            // 
            // dataTimeInicio
            // 
            this.dataTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dataTimeInicio.Location = new System.Drawing.Point(175, 180);
            this.dataTimeInicio.Name = "dataTimeInicio";
            this.dataTimeInicio.Size = new System.Drawing.Size(200, 20);
            this.dataTimeInicio.TabIndex = 11;
            // 
            // txtCantidadKm
            // 
            this.txtCantidadKm.Location = new System.Drawing.Point(345, 140);
            this.txtCantidadKm.Name = "txtCantidadKm";
            this.txtCantidadKm.Size = new System.Drawing.Size(45, 20);
            this.txtCantidadKm.TabIndex = 12;
            this.txtCantidadKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadKm_KeyPress);
            // 
            // btnRegistrarViaje
            // 
            this.btnRegistrarViaje.Location = new System.Drawing.Point(123, 253);
            this.btnRegistrarViaje.Name = "btnRegistrarViaje";
            this.btnRegistrarViaje.Size = new System.Drawing.Size(252, 63);
            this.btnRegistrarViaje.TabIndex = 13;
            this.btnRegistrarViaje.Text = "Registrar Viaje";
            this.btnRegistrarViaje.UseVisualStyleBackColor = true;
            this.btnRegistrarViaje.Click += new System.EventHandler(this.btnRegistrarViaje_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(14, 57);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 14;
            this.lblCliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(65, 55);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 15;
            // 
            // RegistroViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 333);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnRegistrarViaje);
            this.Controls.Add(this.txtCantidadKm);
            this.Controls.Add(this.dataTimeInicio);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.cmbTurnos);
            this.Controls.Add(this.cmbAutomovil);
            this.Controls.Add(this.cmbChoferes);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblCantidadKilometros);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblAutomovil);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblChofer);
            this.Name = "RegistroViaje";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblCantidadKilometros;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.ComboBox cmbChoferes;
        private System.Windows.Forms.ComboBox cmbAutomovil;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.DateTimePicker dataTimeInicio;
        private System.Windows.Forms.TextBox txtCantidadKm;
        private System.Windows.Forms.Button btnRegistrarViaje;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}