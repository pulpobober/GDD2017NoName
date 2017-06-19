namespace UberFrba.Menu_Acciones
{
    partial class MenuAcciones
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
            this.lblMenuAcciones = new System.Windows.Forms.Label();
            this.cmbAcciones = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarAccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuAcciones
            // 
            this.lblMenuAcciones.AutoSize = true;
            this.lblMenuAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuAcciones.Location = new System.Drawing.Point(99, 24);
            this.lblMenuAcciones.Name = "lblMenuAcciones";
            this.lblMenuAcciones.Size = new System.Drawing.Size(233, 31);
            this.lblMenuAcciones.TabIndex = 0;
            this.lblMenuAcciones.Text = "Menu de acciones";
            // 
            // cmbAcciones
            // 
            this.cmbAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcciones.FormattingEnabled = true;
            this.cmbAcciones.Location = new System.Drawing.Point(32, 88);
            this.cmbAcciones.Name = "cmbAcciones";
            this.cmbAcciones.Size = new System.Drawing.Size(366, 28);
            this.cmbAcciones.TabIndex = 1;
            // 
            // btnSeleccionarAccion
            // 
            this.btnSeleccionarAccion.Location = new System.Drawing.Point(156, 143);
            this.btnSeleccionarAccion.Name = "btnSeleccionarAccion";
            this.btnSeleccionarAccion.Size = new System.Drawing.Size(124, 46);
            this.btnSeleccionarAccion.TabIndex = 2;
            this.btnSeleccionarAccion.Text = "Seleccionar Accion";
            this.btnSeleccionarAccion.UseVisualStyleBackColor = true;
            this.btnSeleccionarAccion.Click += new System.EventHandler(this.btnSeleccionarAccion_Click);
            // 
            // MenuAcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 214);
            this.Controls.Add(this.btnSeleccionarAccion);
            this.Controls.Add(this.cmbAcciones);
            this.Controls.Add(this.lblMenuAcciones);
            this.Name = "MenuAcciones";
            this.Text = "MenuAcciones";
            this.Load += new System.EventHandler(this.MenuAcciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuAcciones;
        private System.Windows.Forms.ComboBox cmbAcciones;
        private System.Windows.Forms.Button btnSeleccionarAccion;
    }
}