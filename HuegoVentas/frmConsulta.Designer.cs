
namespace HuergoVentas
{
    partial class frmConsulta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
			this.btNuevo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txFiltro = new System.Windows.Forms.TextBox();
			this.btBuscar = new System.Windows.Forms.Button();
			this.gvClientes = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// btNuevo
			// 
			this.btNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btNuevo.Location = new System.Drawing.Point(479, 393);
			this.btNuevo.Margin = new System.Windows.Forms.Padding(2);
			this.btNuevo.Name = "btNuevo";
			this.btNuevo.Size = new System.Drawing.Size(160, 33);
			this.btNuevo.TabIndex = 13;
			this.btNuevo.Text = "Nuevo";
			this.btNuevo.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Filtro";
			// 
			// txFiltro
			// 
			this.txFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txFiltro.Location = new System.Drawing.Point(55, 31);
			this.txFiltro.Margin = new System.Windows.Forms.Padding(2);
			this.txFiltro.Name = "txFiltro";
			this.txFiltro.Size = new System.Drawing.Size(421, 20);
			this.txFiltro.TabIndex = 9;
			// 
			// btBuscar
			// 
			this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btBuscar.Location = new System.Drawing.Point(479, 24);
			this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
			this.btBuscar.Name = "btBuscar";
			this.btBuscar.Size = new System.Drawing.Size(160, 33);
			this.btBuscar.TabIndex = 8;
			this.btBuscar.Text = "Buscar";
			this.btBuscar.UseVisualStyleBackColor = true;
			this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
			// 
			// gvClientes
			// 
			this.gvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvClientes.Location = new System.Drawing.Point(21, 108);
			this.gvClientes.Margin = new System.Windows.Forms.Padding(2);
			this.gvClientes.Name = "gvClientes";
			this.gvClientes.RowTemplate.Height = 24;
			this.gvClientes.Size = new System.Drawing.Size(618, 280);
			this.gvClientes.TabIndex = 7;
			// 
			// frmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 450);
			this.Controls.Add(this.btNuevo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txFiltro);
			this.Controls.Add(this.btBuscar);
			this.Controls.Add(this.gvClientes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsulta";
			this.Text = "Consulta de Ventas";
			this.Load += new System.EventHandler(this.frmConsulta_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txFiltro;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView gvClientes;
    }
}