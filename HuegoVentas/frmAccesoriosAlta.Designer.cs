
namespace HuegoVentas
{
    partial class frmAccesoriosAlta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccesoriosAlta));
			this.btCancelar = new System.Windows.Forms.Button();
			this.btCrear = new System.Windows.Forms.Button();
			this.txbPrecio = new System.Windows.Forms.TextBox();
			this.lbPrecio = new System.Windows.Forms.Label();
			this.txbNombre = new System.Windows.Forms.TextBox();
			this.lbNombre = new System.Windows.Forms.Label();
			this.txbModelo = new System.Windows.Forms.TextBox();
			this.txbID = new System.Windows.Forms.TextBox();
			this.lbID = new System.Windows.Forms.Label();
			this.lbModelo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btCancelar
			// 
			this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btCancelar.Location = new System.Drawing.Point(18, 246);
			this.btCancelar.Name = "btCancelar";
			this.btCancelar.Size = new System.Drawing.Size(116, 34);
			this.btCancelar.TabIndex = 49;
			this.btCancelar.Text = "Cancelar";
			this.btCancelar.UseVisualStyleBackColor = true;
			this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
			// 
			// btCrear
			// 
			this.btCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCrear.Location = new System.Drawing.Point(189, 246);
			this.btCrear.Name = "btCrear";
			this.btCrear.Size = new System.Drawing.Size(116, 34);
			this.btCrear.TabIndex = 48;
			this.btCrear.Text = "Crear";
			this.btCrear.UseVisualStyleBackColor = true;
			this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
			// 
			// txbPrecio
			// 
			this.txbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbPrecio.Location = new System.Drawing.Point(193, 129);
			this.txbPrecio.Name = "txbPrecio";
			this.txbPrecio.Size = new System.Drawing.Size(100, 20);
			this.txbPrecio.TabIndex = 47;
			// 
			// lbPrecio
			// 
			this.lbPrecio.AutoSize = true;
			this.lbPrecio.Location = new System.Drawing.Point(28, 132);
			this.lbPrecio.Name = "lbPrecio";
			this.lbPrecio.Size = new System.Drawing.Size(40, 13);
			this.lbPrecio.TabIndex = 46;
			this.lbPrecio.Text = "Precio ";
			// 
			// txbNombre
			// 
			this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbNombre.Location = new System.Drawing.Point(193, 77);
			this.txbNombre.Name = "txbNombre";
			this.txbNombre.Size = new System.Drawing.Size(100, 20);
			this.txbNombre.TabIndex = 45;
			// 
			// lbNombre
			// 
			this.lbNombre.AutoSize = true;
			this.lbNombre.Location = new System.Drawing.Point(28, 80);
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Size = new System.Drawing.Size(44, 13);
			this.lbNombre.TabIndex = 44;
			this.lbNombre.Text = "Nombre";
			// 
			// txbModelo
			// 
			this.txbModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbModelo.Location = new System.Drawing.Point(193, 103);
			this.txbModelo.Name = "txbModelo";
			this.txbModelo.Size = new System.Drawing.Size(100, 20);
			this.txbModelo.TabIndex = 43;
			// 
			// txbID
			// 
			this.txbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbID.Location = new System.Drawing.Point(193, 51);
			this.txbID.Name = "txbID";
			this.txbID.ReadOnly = true;
			this.txbID.Size = new System.Drawing.Size(100, 20);
			this.txbID.TabIndex = 41;
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.Location = new System.Drawing.Point(28, 54);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(18, 13);
			this.lbID.TabIndex = 40;
			this.lbID.Text = "ID";
			// 
			// lbModelo
			// 
			this.lbModelo.AutoSize = true;
			this.lbModelo.Location = new System.Drawing.Point(28, 106);
			this.lbModelo.Name = "lbModelo";
			this.lbModelo.Size = new System.Drawing.Size(42, 13);
			this.lbModelo.TabIndex = 42;
			this.lbModelo.Text = "Modelo";
			this.lbModelo.Click += new System.EventHandler(this.lbTipo_Click);
			// 
			// frmAccesoriosAlta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 331);
			this.Controls.Add(this.btCancelar);
			this.Controls.Add(this.btCrear);
			this.Controls.Add(this.txbPrecio);
			this.Controls.Add(this.lbPrecio);
			this.Controls.Add(this.txbNombre);
			this.Controls.Add(this.lbNombre);
			this.Controls.Add(this.txbModelo);
			this.Controls.Add(this.lbModelo);
			this.Controls.Add(this.txbID);
			this.Controls.Add(this.lbID);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAccesoriosAlta";
			this.Text = "}";
			this.Load += new System.EventHandler(this.frmAccesoriosAlta_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbModelo;
    }
}