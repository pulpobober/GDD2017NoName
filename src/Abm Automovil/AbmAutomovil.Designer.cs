using System.Data.SqlClient;
using UberFrba.ConexionBD;

namespace UberFrba.Abm_Automovil
{
    partial class AbmAutomovil
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
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.selectMarca = new System.Windows.Forms.ComboBox();
            this.lblRodado = new System.Windows.Forms.Label();
            this.txtRodado = new System.Windows.Forms.TextBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.lblLicencia = new System.Windows.Forms.Label();

            
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(82, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 37);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "ABM Automovil";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(34, 158);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPatente.Location = new System.Drawing.Point(34, 122);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 3;
            this.lblPatente.Text = "Patente";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(34, 86);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 4;
            this.lblTurno.Text = "Turno:";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(34, 226);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(41, 13);
            this.lblChofer.TabIndex = 5;
            this.lblChofer.Text = "Chofer:";
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(34, 191);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(100, 20);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca: ";
            // lblRodado
            // 
            this.lblRodado.Location = new System.Drawing.Point(34, 191);
            this.lblRodado.Name = "lblRodado";
            this.lblRodado.Size = new System.Drawing.Size(100, 20);
            this.lblRodado.TabIndex = 6;
            this.lblRodado.Text = "Rodado: ";
            // 
            // lblLicencia
            // 
            this.lblLicencia.Location = new System.Drawing.Point(34, 191);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(100, 20);
            this.lblLicencia.TabIndex = 6;
            this.lblLicencia.Text = "Licencia: ";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(188, 151);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(188, 115);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 8;
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(188, 79);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(100, 20);
            this.txtTurno.TabIndex = 9;
            // 
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(188, 226);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(100, 20);
            this.txtChofer.TabIndex = 10;
            // 
            // txtRodado
            // 
            this.txtRodado.Location = new System.Drawing.Point(188, 226);
            this.txtRodado.Name = "txtRodado";
            this.txtRodado.Size = new System.Drawing.Size(100, 20);
            this.txtRodado.TabIndex = 10;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(188, 226);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(100, 20);
            this.txtLicencia.TabIndex = 10;
            // 
            // selectMarca
            // 
            this.selectMarca.Location = new System.Drawing.Point(188, 194);
            this.selectMarca.Name = "selectMarca";
            this.selectMarca.DataSource=SQLAutomovil.obtain_marcas();
            this.selectMarca.Size = new System.Drawing.Size(171, 17);
            this.selectMarca.TabIndex = 1;
            // 
            // AbmAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 338);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.txtChofer);
            this.Controls.Add(this.txtRodado);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.selectMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.lblRodado);
            this.Controls.Add(this.lblLicencia);
            this.Name = "AbmAutomovil";
            this.Text = "AbmAutomovil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       
        #endregion

        protected System.Windows.Forms.ComboBox selectMarca;
        protected System.Windows.Forms.Label lblModelo;
        protected System.Windows.Forms.Label lblPatente;
        protected System.Windows.Forms.Label lblTurno;
        protected System.Windows.Forms.Label lblChofer;
        protected System.Windows.Forms.TextBox txtModelo;
        protected System.Windows.Forms.TextBox txtPatente;
        protected System.Windows.Forms.TextBox txtTurno;
        protected System.Windows.Forms.TextBox txtChofer;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Label lblMarca;
        protected System.Windows.Forms.Label lblRodado;
        protected System.Windows.Forms.Label lblLicencia;
        protected System.Windows.Forms.TextBox txtLicencia;
        protected System.Windows.Forms.TextBox txtRodado;
    }
}