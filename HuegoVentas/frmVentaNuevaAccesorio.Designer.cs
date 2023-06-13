namespace HuegoVentas
{
    partial class frmVentaNuevaAccesorio
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
            this.label5 = new System.Windows.Forms.Label();
            this.nuCantidad = new System.Windows.Forms.NumericUpDown();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddAccesorio = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Accesorio de la Venta";
            // 
            // nuCantidad
            // 
            this.nuCantidad.Location = new System.Drawing.Point(135, 100);
            this.nuCantidad.Name = "nuCantidad";
            this.nuCantidad.Size = new System.Drawing.Size(86, 20);
            this.nuCantidad.TabIndex = 48;
            this.nuCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txTotal
            // 
            this.txTotal.Location = new System.Drawing.Point(135, 152);
            this.txTotal.Name = "txTotal";
            this.txTotal.ReadOnly = true;
            this.txTotal.Size = new System.Drawing.Size(151, 20);
            this.txTotal.TabIndex = 47;
            this.txTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Cantidad:";
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(135, 126);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.ReadOnly = true;
            this.txPrecio.Size = new System.Drawing.Size(151, 20);
            this.txPrecio.TabIndex = 44;
            this.txPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Accesorio:";
            // 
            // ddAccesorio
            // 
            this.ddAccesorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddAccesorio.FormattingEnabled = true;
            this.ddAccesorio.Location = new System.Drawing.Point(135, 73);
            this.ddAccesorio.Name = "ddAccesorio";
            this.ddAccesorio.Size = new System.Drawing.Size(244, 21);
            this.ddAccesorio.TabIndex = 41;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelar.Location = new System.Drawing.Point(25, 178);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(200, 23);
            this.btCancelar.TabIndex = 40;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.Location = new System.Drawing.Point(261, 178);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(200, 23);
            this.btAceptar.TabIndex = 39;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // frmNuevaVentaAccesorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 217);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nuCantidad);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddAccesorio);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Name = "frmNuevaVentaAccesorio";
            this.Text = "frmNuevaVentaAccesorio";
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nuCantidad;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddAccesorio;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
    }
}