namespace UberFrba.Abm_Rol
{
    partial class AbmRol
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.checkListFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(67, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Roles";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Rol:";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(89, 50);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(173, 20);
            this.txtNombreRol.TabIndex = 2;
            // 
            // checkListFuncionalidades
            // 
            this.checkListFuncionalidades.FormattingEnabled = true;
            this.checkListFuncionalidades.Location = new System.Drawing.Point(12, 114);
            this.checkListFuncionalidades.Name = "checkListFuncionalidades";
            this.checkListFuncionalidades.Size = new System.Drawing.Size(453, 124);
            this.checkListFuncionalidades.TabIndex = 3;
            // 
            // lblFuncionalidades
            // 
            this.lblFuncionalidades.AutoSize = true;
            this.lblFuncionalidades.Location = new System.Drawing.Point(12, 95);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(84, 13);
            this.lblFuncionalidades.TabIndex = 4;
            this.lblFuncionalidades.Text = "Funcionalidades";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(285, 53);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(331, 49);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(134, 21);
            this.cmbEstado.TabIndex = 6;
            // 
            // AbmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 262);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFuncionalidades);
            this.Controls.Add(this.checkListFuncionalidades);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "AbmRol";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AbmRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.TextBox txtNombreRol;
        protected System.Windows.Forms.CheckedListBox checkListFuncionalidades;
        protected System.Windows.Forms.Label lblFuncionalidades;
        protected System.Windows.Forms.Label lblEstado;
        protected System.Windows.Forms.ComboBox cmbEstado;

    }
}