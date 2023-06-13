
namespace HuegoVentas
{
	partial class frmVehiculosAlta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculosAlta));
			this.btCancelar = new System.Windows.Forms.Button();
			this.btCrear = new System.Windows.Forms.Button();
			this.txbPrecioVenta = new System.Windows.Forms.TextBox();
			this.lbPrecioVenta = new System.Windows.Forms.Label();
			this.txbModelo = new System.Windows.Forms.TextBox();
			this.lbModelo = new System.Windows.Forms.Label();
			this.txbTipo = new System.Windows.Forms.TextBox();
			this.lbTipo = new System.Windows.Forms.Label();
			this.txbID = new System.Windows.Forms.TextBox();
			this.lbID = new System.Windows.Forms.Label();
			this.txbStock = new System.Windows.Forms.TextBox();
			this.lbStock = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btCancelar
			// 
			this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btCancelar.Location = new System.Drawing.Point(19, 214);
			this.btCancelar.Name = "btCancelar";
			this.btCancelar.Size = new System.Drawing.Size(116, 34);
			this.btCancelar.TabIndex = 37;
			this.btCancelar.Text = "Cancelar";
			this.btCancelar.UseVisualStyleBackColor = true;
			this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
			// 
			// btCrear
			// 
			this.btCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCrear.Location = new System.Drawing.Point(190, 214);
			this.btCrear.Name = "btCrear";
			this.btCrear.Size = new System.Drawing.Size(116, 34);
			this.btCrear.TabIndex = 36;
			this.btCrear.Text = "Crear";
			this.btCrear.UseVisualStyleBackColor = true;
			this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
			// 
			// txbPrecioVenta
			// 
			this.txbPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbPrecioVenta.Location = new System.Drawing.Point(194, 97);
			this.txbPrecioVenta.Name = "txbPrecioVenta";
			this.txbPrecioVenta.Size = new System.Drawing.Size(100, 20);
			this.txbPrecioVenta.TabIndex = 35;
			// 
			// lbPrecioVenta
			// 
			this.lbPrecioVenta.AutoSize = true;
			this.lbPrecioVenta.Location = new System.Drawing.Point(29, 100);
			this.lbPrecioVenta.Name = "lbPrecioVenta";
			this.lbPrecioVenta.Size = new System.Drawing.Size(68, 13);
			this.lbPrecioVenta.TabIndex = 34;
			this.lbPrecioVenta.Text = "Precio Venta";
			// 
			// txbModelo
			// 
			this.txbModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbModelo.Location = new System.Drawing.Point(194, 71);
			this.txbModelo.Name = "txbModelo";
			this.txbModelo.Size = new System.Drawing.Size(100, 20);
			this.txbModelo.TabIndex = 33;
			// 
			// lbModelo
			// 
			this.lbModelo.AutoSize = true;
			this.lbModelo.Location = new System.Drawing.Point(29, 74);
			this.lbModelo.Name = "lbModelo";
			this.lbModelo.Size = new System.Drawing.Size(42, 13);
			this.lbModelo.TabIndex = 32;
			this.lbModelo.Text = "Modelo";
			// 
			// txbTipo
			// 
			this.txbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbTipo.Location = new System.Drawing.Point(194, 45);
			this.txbTipo.Name = "txbTipo";
			this.txbTipo.Size = new System.Drawing.Size(100, 20);
			this.txbTipo.TabIndex = 31;
			// 
			// lbTipo
			// 
			this.lbTipo.AutoSize = true;
			this.lbTipo.Location = new System.Drawing.Point(29, 48);
			this.lbTipo.Name = "lbTipo";
			this.lbTipo.Size = new System.Drawing.Size(28, 13);
			this.lbTipo.TabIndex = 30;
			this.lbTipo.Text = "Tipo";
			// 
			// txbID
			// 
			this.txbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbID.Location = new System.Drawing.Point(194, 19);
			this.txbID.Name = "txbID";
			this.txbID.ReadOnly = true;
			this.txbID.Size = new System.Drawing.Size(100, 20);
			this.txbID.TabIndex = 29;
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.Location = new System.Drawing.Point(29, 22);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(18, 13);
			this.lbID.TabIndex = 28;
			this.lbID.Text = "ID";
			// 
			// txbStock
			// 
			this.txbStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbStock.Location = new System.Drawing.Point(195, 123);
			this.txbStock.Name = "txbStock";
			this.txbStock.Size = new System.Drawing.Size(100, 20);
			this.txbStock.TabIndex = 39;
			// 
			// lbStock
			// 
			this.lbStock.AutoSize = true;
			this.lbStock.Location = new System.Drawing.Point(30, 126);
			this.lbStock.Name = "lbStock";
			this.lbStock.Size = new System.Drawing.Size(35, 13);
			this.lbStock.TabIndex = 38;
			this.lbStock.Text = "Stock";
			// 
			// frmVehiculosAlta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 267);
			this.Controls.Add(this.txbStock);
			this.Controls.Add(this.lbStock);
			this.Controls.Add(this.btCancelar);
			this.Controls.Add(this.btCrear);
			this.Controls.Add(this.txbPrecioVenta);
			this.Controls.Add(this.lbPrecioVenta);
			this.Controls.Add(this.txbModelo);
			this.Controls.Add(this.lbModelo);
			this.Controls.Add(this.txbTipo);
			this.Controls.Add(this.lbTipo);
			this.Controls.Add(this.txbID);
			this.Controls.Add(this.lbID);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmVehiculosAlta";
			this.Text = "Vehiculo";
			this.Load += new System.EventHandler(this.frmVehiculosAlta_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btCancelar;
		private System.Windows.Forms.Button btCrear;
		private System.Windows.Forms.TextBox txbPrecioVenta;
		private System.Windows.Forms.Label lbPrecioVenta;
		private System.Windows.Forms.TextBox txbModelo;
		private System.Windows.Forms.Label lbModelo;
		private System.Windows.Forms.TextBox txbTipo;
		private System.Windows.Forms.Label lbTipo;
		private System.Windows.Forms.TextBox txbID;
		private System.Windows.Forms.Label lbID;
		private System.Windows.Forms.TextBox txbStock;
		private System.Windows.Forms.Label lbStock;
	}
}