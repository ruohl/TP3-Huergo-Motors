namespace HuegoVentas
{
    partial class frmClientes
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
			this.gvClientes = new System.Windows.Forms.DataGridView();
			this.btBuscar = new System.Windows.Forms.Button();
			this.txFiltro = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btEliminar = new System.Windows.Forms.Button();
			this.btEditar = new System.Windows.Forms.Button();
			this.btNuevo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// gvClientes
			// 
			this.gvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvClientes.Location = new System.Drawing.Point(9, 94);
			this.gvClientes.Margin = new System.Windows.Forms.Padding(2);
			this.gvClientes.Name = "gvClientes";
			this.gvClientes.RowTemplate.Height = 24;
			this.gvClientes.Size = new System.Drawing.Size(635, 280);
			this.gvClientes.TabIndex = 0;
			// 
			// btBuscar
			// 
			this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btBuscar.Location = new System.Drawing.Point(484, 10);
			this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
			this.btBuscar.Name = "btBuscar";
			this.btBuscar.Size = new System.Drawing.Size(160, 33);
			this.btBuscar.TabIndex = 1;
			this.btBuscar.Text = "Buscar";
			this.btBuscar.UseVisualStyleBackColor = true;
			this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
			// 
			// txFiltro
			// 
			this.txFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txFiltro.Location = new System.Drawing.Point(43, 17);
			this.txFiltro.Margin = new System.Windows.Forms.Padding(2);
			this.txFiltro.Name = "txFiltro";
			this.txFiltro.Size = new System.Drawing.Size(438, 20);
			this.txFiltro.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Filtro";
			// 
			// btEliminar
			// 
			this.btEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btEliminar.Location = new System.Drawing.Point(156, 379);
			this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
			this.btEliminar.Name = "btEliminar";
			this.btEliminar.Size = new System.Drawing.Size(160, 33);
			this.btEliminar.TabIndex = 4;
			this.btEliminar.Text = "Eliminar";
			this.btEliminar.UseVisualStyleBackColor = true;
			this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
			// 
			// btEditar
			// 
			this.btEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btEditar.Location = new System.Drawing.Point(320, 379);
			this.btEditar.Margin = new System.Windows.Forms.Padding(2);
			this.btEditar.Name = "btEditar";
			this.btEditar.Size = new System.Drawing.Size(160, 33);
			this.btEditar.TabIndex = 5;
			this.btEditar.Text = "Editar";
			this.btEditar.UseVisualStyleBackColor = true;
			this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
			// 
			// btNuevo
			// 
			this.btNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btNuevo.Location = new System.Drawing.Point(484, 379);
			this.btNuevo.Margin = new System.Windows.Forms.Padding(2);
			this.btNuevo.Name = "btNuevo";
			this.btNuevo.Size = new System.Drawing.Size(160, 33);
			this.btNuevo.TabIndex = 6;
			this.btNuevo.Text = "Nuevo";
			this.btNuevo.UseVisualStyleBackColor = true;
			this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
			// 
			// frmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 420);
			this.Controls.Add(this.btNuevo);
			this.Controls.Add(this.btEditar);
			this.Controls.Add(this.btEliminar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txFiltro);
			this.Controls.Add(this.btBuscar);
			this.Controls.Add(this.gvClientes);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmClientes";
			this.Text = "frmClientes";
			((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvClientes;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btNuevo;
	}
}