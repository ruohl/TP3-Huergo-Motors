
namespace HuegoVentas
{
	partial class frmAccesorios
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
			this.btNuevo = new System.Windows.Forms.Button();
			this.btEditar = new System.Windows.Forms.Button();
			this.btEliminar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txFiltro = new System.Windows.Forms.TextBox();
			this.btBuscar = new System.Windows.Forms.Button();
			this.gvAccesorios = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gvAccesorios)).BeginInit();
			this.SuspendLayout();
			// 
			// btNuevo
			// 
			this.btNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btNuevo.Location = new System.Drawing.Point(510, 393);
			this.btNuevo.Margin = new System.Windows.Forms.Padding(2);
			this.btNuevo.Name = "btNuevo";
			this.btNuevo.Size = new System.Drawing.Size(160, 33);
			this.btNuevo.TabIndex = 20;
			this.btNuevo.Text = "Nuevo";
			this.btNuevo.UseVisualStyleBackColor = true;
			// 
			// btEditar
			// 
			this.btEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btEditar.Location = new System.Drawing.Point(346, 393);
			this.btEditar.Margin = new System.Windows.Forms.Padding(2);
			this.btEditar.Name = "btEditar";
			this.btEditar.Size = new System.Drawing.Size(160, 33);
			this.btEditar.TabIndex = 19;
			this.btEditar.Text = "Editar";
			this.btEditar.UseVisualStyleBackColor = true;
			// 
			// btEliminar
			// 
			this.btEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btEliminar.Location = new System.Drawing.Point(182, 393);
			this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
			this.btEliminar.Name = "btEliminar";
			this.btEliminar.Size = new System.Drawing.Size(160, 33);
			this.btEliminar.TabIndex = 18;
			this.btEliminar.Text = "Eliminar";
			this.btEliminar.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Filtro";
			// 
			// txFiltro
			// 
			this.txFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txFiltro.Location = new System.Drawing.Point(69, 31);
			this.txFiltro.Margin = new System.Windows.Forms.Padding(2);
			this.txFiltro.Name = "txFiltro";
			this.txFiltro.Size = new System.Drawing.Size(438, 20);
			this.txFiltro.TabIndex = 16;
			// 
			// btBuscar
			// 
			this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btBuscar.Location = new System.Drawing.Point(510, 24);
			this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
			this.btBuscar.Name = "btBuscar";
			this.btBuscar.Size = new System.Drawing.Size(160, 33);
			this.btBuscar.TabIndex = 15;
			this.btBuscar.Text = "Buscar";
			this.btBuscar.UseVisualStyleBackColor = true;
			// 
			// gvAccesorios
			// 
			this.gvAccesorios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gvAccesorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvAccesorios.Location = new System.Drawing.Point(35, 108);
			this.gvAccesorios.Margin = new System.Windows.Forms.Padding(2);
			this.gvAccesorios.Name = "gvAccesorios";
			this.gvAccesorios.RowTemplate.Height = 24;
			this.gvAccesorios.Size = new System.Drawing.Size(635, 280);
			this.gvAccesorios.TabIndex = 14;
			// 
			// frmAccesorios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 450);
			this.Controls.Add(this.btNuevo);
			this.Controls.Add(this.btEditar);
			this.Controls.Add(this.btEliminar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txFiltro);
			this.Controls.Add(this.btBuscar);
			this.Controls.Add(this.gvAccesorios);
			this.Name = "frmAccesorios";
			this.Text = "frmAccesorios";
			((System.ComponentModel.ISupportInitialize)(this.gvAccesorios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btNuevo;
		private System.Windows.Forms.Button btEditar;
		private System.Windows.Forms.Button btEliminar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txFiltro;
		private System.Windows.Forms.Button btBuscar;
		private System.Windows.Forms.DataGridView gvAccesorios;
	}
}