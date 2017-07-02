namespace UberFrba.Abm_Turno
{
    partial class AbmTurno
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHoraFinalizacion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblValorKilometro = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.ckbHabilitado = new System.Windows.Forms.CheckBox();
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.cmbFinal = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtValorKm = new System.Windows.Forms.TextBox();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Abm Turno";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(68, 64);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(61, 13);
            this.lblHoraInicio.TabIndex = 1;
            this.lblHoraInicio.Text = "Hora Inicio:";
            // 
            // lblHoraFinalizacion
            // 
            this.lblHoraFinalizacion.AutoSize = true;
            this.lblHoraFinalizacion.Location = new System.Drawing.Point(38, 103);
            this.lblHoraFinalizacion.Name = "lblHoraFinalizacion";
            this.lblHoraFinalizacion.Size = new System.Drawing.Size(91, 13);
            this.lblHoraFinalizacion.TabIndex = 2;
            this.lblHoraFinalizacion.Text = "Hora Finalizacion:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(63, 142);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblValorKilometro
            // 
            this.lblValorKilometro.AutoSize = true;
            this.lblValorKilometro.Location = new System.Drawing.Point(49, 180);
            this.lblValorKilometro.Name = "lblValorKilometro";
            this.lblValorKilometro.Size = new System.Drawing.Size(80, 13);
            this.lblValorKilometro.TabIndex = 4;
            this.lblValorKilometro.Text = "Valor Kilometro:";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(19, 222);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(110, 13);
            this.lblPrecioBase.TabIndex = 5;
            this.lblPrecioBase.Text = "Precio base del turno:";
            // 
            // ckbHabilitado
            // 
            this.ckbHabilitado.AutoSize = true;
            this.ckbHabilitado.Checked = true;
            this.ckbHabilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHabilitado.Location = new System.Drawing.Point(115, 264);
            this.ckbHabilitado.Name = "ckbHabilitado";
            this.ckbHabilitado.Size = new System.Drawing.Size(73, 17);
            this.ckbHabilitado.TabIndex = 6;
            this.ckbHabilitado.Text = "Habilitado";
            this.ckbHabilitado.UseVisualStyleBackColor = true;
            // 
            // cmbInicio
            // 
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Location = new System.Drawing.Point(135, 61);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(121, 21);
            this.cmbInicio.TabIndex = 7;
            // 
            // cmbFinal
            // 
            this.cmbFinal.FormattingEnabled = true;
            this.cmbFinal.Location = new System.Drawing.Point(135, 100);
            this.cmbFinal.Name = "cmbFinal";
            this.cmbFinal.Size = new System.Drawing.Size(121, 21);
            this.cmbFinal.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(135, 139);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtValorKm
            // 
            this.txtValorKm.Location = new System.Drawing.Point(135, 180);
            this.txtValorKm.Name = "txtValorKm";
            this.txtValorKm.Size = new System.Drawing.Size(37, 20);
            this.txtValorKm.TabIndex = 10;
            //this.txtValorKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorKm_KeyPress);
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(136, 222);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(36, 20);
            this.txtPrecioBase.TabIndex = 11;
            //this.txtPrecioBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioBase_KeyPress);
            // 
            // AbmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 350);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.txtValorKm);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbFinal);
            this.Controls.Add(this.cmbInicio);
            this.Controls.Add(this.ckbHabilitado);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblValorKilometro);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblHoraFinalizacion);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblTitulo);
            this.Name = "AbmTurno";
            this.Text = "AbmTurno";
            this.Load += new System.EventHandler(this.AbmTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Label lblHoraInicio;
        protected System.Windows.Forms.Label lblHoraFinalizacion;
        protected System.Windows.Forms.Label lblDescripcion;
        protected System.Windows.Forms.Label lblValorKilometro;
        protected System.Windows.Forms.Label lblPrecioBase;
        protected System.Windows.Forms.CheckBox ckbHabilitado;
        protected System.Windows.Forms.ComboBox cmbInicio;
        protected System.Windows.Forms.ComboBox cmbFinal;
        protected System.Windows.Forms.TextBox txtDescripcion;
        protected System.Windows.Forms.TextBox txtValorKm;
        protected System.Windows.Forms.TextBox txtPrecioBase;

    }
}