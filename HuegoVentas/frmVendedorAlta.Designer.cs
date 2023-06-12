
using System;

namespace HuegoVentas
{
	partial class frmVendedorAlta
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
			this.btCancelar = new System.Windows.Forms.Button();
			this.btCrear = new System.Windows.Forms.Button();
			this.txbSucursal = new System.Windows.Forms.TextBox();
			this.lbTelefono = new System.Windows.Forms.Label();
			this.txbApellido = new System.Windows.Forms.TextBox();
			this.lbDireccion = new System.Windows.Forms.Label();
			this.txbNombre = new System.Windows.Forms.TextBox();
			this.lbNombre = new System.Windows.Forms.Label();
			this.txbID = new System.Windows.Forms.TextBox();
			this.lbID = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btCancelar
			// 
			this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btCancelar.Location = new System.Drawing.Point(10, 233);
			this.btCancelar.Name = "btCancelar";
			this.btCancelar.Size = new System.Drawing.Size(116, 34);
			this.btCancelar.TabIndex = 27;
			this.btCancelar.Text = "Cancelar";
			this.btCancelar.UseVisualStyleBackColor = true;
			// 
			// btCrear
			// 
			this.btCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCrear.Location = new System.Drawing.Point(181, 233);
			this.btCrear.Name = "btCrear";
			this.btCrear.Size = new System.Drawing.Size(116, 34);
			this.btCrear.TabIndex = 26;
			this.btCrear.Text = "Crear";
			this.btCrear.UseVisualStyleBackColor = true;
			this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
			// 
			// txbSucursal
			// 
			this.txbSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbSucursal.Location = new System.Drawing.Point(185, 116);
			this.txbSucursal.Name = "txbSucursal";
			this.txbSucursal.Size = new System.Drawing.Size(100, 20);
			this.txbSucursal.TabIndex = 21;
			// 
			// lbTelefono
			// 
			this.lbTelefono.AutoSize = true;
			this.lbTelefono.Location = new System.Drawing.Point(20, 119);
			this.lbTelefono.Name = "lbTelefono";
			this.lbTelefono.Size = new System.Drawing.Size(48, 13);
			this.lbTelefono.TabIndex = 20;
			this.lbTelefono.Text = "Sucursal";
			// 
			// txbApellido
			// 
			this.txbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbApellido.Location = new System.Drawing.Point(185, 90);
			this.txbApellido.Name = "txbApellido";
			this.txbApellido.Size = new System.Drawing.Size(100, 20);
			this.txbApellido.TabIndex = 19;
			// 
			// lbDireccion
			// 
			this.lbDireccion.AutoSize = true;
			this.lbDireccion.Location = new System.Drawing.Point(20, 93);
			this.lbDireccion.Name = "lbDireccion";
			this.lbDireccion.Size = new System.Drawing.Size(44, 13);
			this.lbDireccion.TabIndex = 18;
			this.lbDireccion.Text = "Apellido";
			// 
			// txbNombre
			// 
			this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbNombre.Location = new System.Drawing.Point(185, 64);
			this.txbNombre.Name = "txbNombre";
			this.txbNombre.Size = new System.Drawing.Size(100, 20);
			this.txbNombre.TabIndex = 17;
			// 
			// lbNombre
			// 
			this.lbNombre.AutoSize = true;
			this.lbNombre.Location = new System.Drawing.Point(20, 67);
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Size = new System.Drawing.Size(44, 13);
			this.lbNombre.TabIndex = 16;
			this.lbNombre.Text = "Nombre";
			// 
			// txbID
			// 
			this.txbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbID.Location = new System.Drawing.Point(185, 38);
			this.txbID.Name = "txbID";
			this.txbID.ReadOnly = true;
			this.txbID.Size = new System.Drawing.Size(100, 20);
			this.txbID.TabIndex = 15;
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.Location = new System.Drawing.Point(20, 41);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(18, 13);
			this.lbID.TabIndex = 14;
			this.lbID.Text = "ID";
			// 
			// frmVendedorAlta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 305);
			this.Controls.Add(this.btCancelar);
			this.Controls.Add(this.btCrear);
			this.Controls.Add(this.txbSucursal);
			this.Controls.Add(this.lbTelefono);
			this.Controls.Add(this.txbApellido);
			this.Controls.Add(this.lbDireccion);
			this.Controls.Add(this.txbNombre);
			this.Controls.Add(this.lbNombre);
			this.Controls.Add(this.txbID);
			this.Controls.Add(this.lbID);
			this.Name = "frmVendedorAlta";
			this.Text = "frmVendedoresAlta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		private System.Windows.Forms.Button btCancelar;
		private System.Windows.Forms.Button btCrear;
		private System.Windows.Forms.TextBox txbSucursal;
		private System.Windows.Forms.Label lbTelefono;
		private System.Windows.Forms.TextBox txbApellido;
		private System.Windows.Forms.Label lbDireccion;
		private System.Windows.Forms.TextBox txbNombre;
		private System.Windows.Forms.Label lbNombre;
		private System.Windows.Forms.TextBox txbID;
		private System.Windows.Forms.Label lbID;
	}
}