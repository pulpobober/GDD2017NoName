namespace UberFrba.Abm_Rol
{
    partial class ListadoRoles
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listaRoles = new System.Windows.Forms.DataGridView();
            this.btnRecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(56, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista Roles";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(17, 267);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 39);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Rol";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(133, 267);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 39);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Rol";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listaRoles
            // 
            this.listaRoles.AllowUserToAddRows = false;
            this.listaRoles.AllowUserToDeleteRows = false;
            this.listaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaRoles.Location = new System.Drawing.Point(17, 46);
            this.listaRoles.Name = "listaRoles";
            this.listaRoles.ReadOnly = true;
            this.listaRoles.Size = new System.Drawing.Size(204, 150);
            this.listaRoles.TabIndex = 4;
            this.listaRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaRoles_CellClick);
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRecargar.Location = new System.Drawing.Point(36, 210);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(166, 42);
            this.btnRecargar.TabIndex = 15;
            this.btnRecargar.Text = "Recargar Tabla";
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // ListadoRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 318);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.listaRoles);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListadoRoles";
            this.Text = "ListadoRoles";
            this.Load += new System.EventHandler(this.ListadoRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView listaRoles;
        private System.Windows.Forms.Button btnRecargar;
    }
}