using System.Data.SqlClient;
using UberFrba.ConexionBD;
namespace UberFrba.Abm_Automovil
{
    partial class ListadoAutomoviles
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblChoferNombre = new System.Windows.Forms.Label();
            this.selectMarca = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtChoferNombre = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tablaAutomoviles = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbSeleccionar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblApellidoChofer = new System.Windows.Forms.Label();
            this.txtApellidoChofer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAutomoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(21, 66);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(100, 23);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(208, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 33);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Listado Automoviles";
            // 
            // lblModelo
            // 
            this.lblModelo.Location = new System.Drawing.Point(238, 63);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(57, 23);
            this.lblModelo.TabIndex = 15;
            this.lblModelo.Text = "Modelo: ";
            // 
            // lblPatente
            // 
            this.lblPatente.Location = new System.Drawing.Point(425, 60);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(52, 23);
            this.lblPatente.TabIndex = 16;
            this.lblPatente.Text = "Patente: ";
            // 
            // lblChoferNombre
            // 
            this.lblChoferNombre.Location = new System.Drawing.Point(195, 95);
            this.lblChoferNombre.Name = "lblChoferNombre";
            this.lblChoferNombre.Size = new System.Drawing.Size(86, 23);
            this.lblChoferNombre.TabIndex = 17;
            this.lblChoferNombre.Text = "Nombre Chofer:";
            // 
            // selectMarca
            // 
            this.selectMarca.Location = new System.Drawing.Point(70, 63);
            this.selectMarca.Name = "selectMarca";
            this.selectMarca.Size = new System.Drawing.Size(121, 21);
            this.selectMarca.TabIndex = 18;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(301, 63);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 19;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(483, 60);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 20;
            // 
            // txtChoferNombre
            // 
            this.txtChoferNombre.Location = new System.Drawing.Point(287, 92);
            this.txtChoferNombre.Name = "txtChoferNombre";
            this.txtChoferNombre.Size = new System.Drawing.Size(100, 20);
            this.txtChoferNombre.TabIndex = 21;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(138, 157);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(238, 37);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tablaAutomoviles
            // 
            this.tablaAutomoviles.AllowUserToAddRows = false;
            this.tablaAutomoviles.AllowUserToDeleteRows = false;
            this.tablaAutomoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAutomoviles.Location = new System.Drawing.Point(24, 317);
            this.tablaAutomoviles.MultiSelect = false;
            this.tablaAutomoviles.Name = "tablaAutomoviles";
            this.tablaAutomoviles.ReadOnly = true;
            this.tablaAutomoviles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaAutomoviles.Size = new System.Drawing.Size(562, 181);
            this.tablaAutomoviles.TabIndex = 8;
            this.tablaAutomoviles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAutomoviles_CellClick);
            this.tablaAutomoviles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAutomoviles_CellContentClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(431, 129);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 41);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 10;
            // 
            // lbSeleccionar
            // 
            this.lbSeleccionar.AutoSize = true;
            this.lbSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccionar.Location = new System.Drawing.Point(29, 258);
            this.lbSeleccionar.Name = "lbSeleccionar";
            this.lbSeleccionar.Size = new System.Drawing.Size(347, 25);
            this.lbSeleccionar.TabIndex = 11;
            this.lbSeleccionar.Text = "Seleccione el automovil que quiere";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(24, 516);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(167, 51);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(408, 516);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 51);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // lblApellidoChofer
            // 
            this.lblApellidoChofer.Location = new System.Drawing.Point(405, 92);
            this.lblApellidoChofer.Name = "lblApellidoChofer";
            this.lblApellidoChofer.Size = new System.Drawing.Size(86, 20);
            this.lblApellidoChofer.TabIndex = 22;
            this.lblApellidoChofer.Text = "Apellido Chofer:";
            // 
            // txtApellidoChofer
            // 
            this.txtApellidoChofer.Location = new System.Drawing.Point(497, 92);
            this.txtApellidoChofer.Name = "txtApellidoChofer";
            this.txtApellidoChofer.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoChofer.TabIndex = 23;
            // 
            // ListadoAutomoviles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 591);
            this.Controls.Add(this.lblApellidoChofer);
            this.Controls.Add(this.txtApellidoChofer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lbSeleccionar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblChoferNombre);
            this.Controls.Add(this.selectMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.txtChoferNombre);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tablaAutomoviles);
            this.Controls.Add(this.btnFiltrar);
            this.Name = "ListadoAutomoviles";
            this.Text = "ListaAutomoviles";
            this.Load += new System.EventHandler(this.ListaAutomoviles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaAutomoviles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblMarca;
        protected System.Windows.Forms.Label lblModelo;
        protected System.Windows.Forms.Label lblPatente;
        protected System.Windows.Forms.Label lblChoferNombre;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.ComboBox selectMarca;
        protected System.Windows.Forms.TextBox txtModelo;
        protected System.Windows.Forms.TextBox txtPatente;
        protected System.Windows.Forms.TextBox txtChoferNombre;

        protected System.Windows.Forms.Button btnFiltrar;
        protected System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Label lbSeleccionar;
        protected System.Windows.Forms.DataGridView tablaAutomoviles;
        protected System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        protected System.Windows.Forms.Label lblApellidoChofer;
        protected System.Windows.Forms.TextBox txtApellidoChofer;

    }

}
