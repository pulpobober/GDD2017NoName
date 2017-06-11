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
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidadKilometros = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbChoferes = new System.Windows.Forms.ComboBox();
            this.cmbAutomovil = new System.Windows.Forms.ComboBox();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.dataTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadKm = new System.Windows.Forms.TextBox();
            this.btnRegistrarViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(12, 61);
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
            this.lblAutomovil.Location = new System.Drawing.Point(230, 61);
            this.lblAutomovil.Name = "lblAutomovil";
            this.lblAutomovil.Size = new System.Drawing.Size(56, 13);
            this.lblAutomovil.TabIndex = 2;
            this.lblAutomovil.Text = "Automovil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turno:";
            // 
            // lblCantidadKilometros
            // 
            this.lblCantidadKilometros.AutoSize = true;
            this.lblCantidadKilometros.Location = new System.Drawing.Point(230, 108);
            this.lblCantidadKilometros.Name = "lblCantidadKilometros";
            this.lblCantidadKilometros.Size = new System.Drawing.Size(103, 13);
            this.lblCantidadKilometros.TabIndex = 4;
            this.lblCantidadKilometros.Text = "Cantidad Kilometros:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(13, 159);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(156, 13);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha y hora de inicio del viaje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha y hora de fin del viaje:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbChoferes
            // 
            this.cmbChoferes.FormattingEnabled = true;
            this.cmbChoferes.Location = new System.Drawing.Point(59, 58);
            this.cmbChoferes.Name = "cmbChoferes";
            this.cmbChoferes.Size = new System.Drawing.Size(121, 21);
            this.cmbChoferes.TabIndex = 7;
            // 
            // cmbAutomovil
            // 
            this.cmbAutomovil.FormattingEnabled = true;
            this.cmbAutomovil.Location = new System.Drawing.Point(292, 58);
            this.cmbAutomovil.Name = "cmbAutomovil";
            this.cmbAutomovil.Size = new System.Drawing.Size(121, 21);
            this.cmbAutomovil.TabIndex = 8;
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(54, 105);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(121, 21);
            this.cmbTurnos.TabIndex = 9;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeFin.Location = new System.Drawing.Point(175, 194);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFin.TabIndex = 10;
            this.dateTimeFin.ValueChanged += new System.EventHandler(this.dateTimeFin_ValueChanged);
            // 
            // dataTimeInicio
            // 
            this.dataTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dataTimeInicio.Location = new System.Drawing.Point(175, 159);
            this.dataTimeInicio.Name = "dataTimeInicio";
            this.dataTimeInicio.Size = new System.Drawing.Size(200, 20);
            this.dataTimeInicio.TabIndex = 11;
            // 
            // txtCantidadKm
            // 
            this.txtCantidadKm.Location = new System.Drawing.Point(339, 105);
            this.txtCantidadKm.Name = "txtCantidadKm";
            this.txtCantidadKm.Size = new System.Drawing.Size(45, 20);
            this.txtCantidadKm.TabIndex = 12;
            // 
            // btnRegistrarViaje
            // 
            this.btnRegistrarViaje.Location = new System.Drawing.Point(123, 241);
            this.btnRegistrarViaje.Name = "btnRegistrarViaje";
            this.btnRegistrarViaje.Size = new System.Drawing.Size(252, 63);
            this.btnRegistrarViaje.TabIndex = 13;
            this.btnRegistrarViaje.Text = "Registrar Viaje";
            this.btnRegistrarViaje.UseVisualStyleBackColor = true;
            this.btnRegistrarViaje.Click += new System.EventHandler(this.btnRegistrarViaje_Click);
            // 
            // RegistroViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 333);
            this.Controls.Add(this.btnRegistrarViaje);
            this.Controls.Add(this.txtCantidadKm);
            this.Controls.Add(this.dataTimeInicio);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.cmbTurnos);
            this.Controls.Add(this.cmbAutomovil);
            this.Controls.Add(this.cmbChoferes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblCantidadKilometros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAutomovil);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblChofer);
            this.Name = "RegistroViaje";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegistroViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadKilometros;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbChoferes;
        private System.Windows.Forms.ComboBox cmbAutomovil;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.DateTimePicker dataTimeInicio;
        private System.Windows.Forms.TextBox txtCantidadKm;
        private System.Windows.Forms.Button btnRegistrarViaje;
    }
}