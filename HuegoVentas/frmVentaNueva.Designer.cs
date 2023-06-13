namespace HuegoVentas
{
    partial class frmVentaNueva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btQuitarAccesorio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.txModelo = new System.Windows.Forms.TextBox();
            this.txTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btAgregarAccesorio = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ddVehiculo = new System.Windows.Forms.ComboBox();
            this.gvAccesorios = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accesorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccesorios)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitarAccesorio
            // 
            this.btQuitarAccesorio.Location = new System.Drawing.Point(207, 204);
            this.btQuitarAccesorio.Name = "btQuitarAccesorio";
            this.btQuitarAccesorio.Size = new System.Drawing.Size(200, 23);
            this.btQuitarAccesorio.TabIndex = 44;
            this.btQuitarAccesorio.Text = "Quitar Accesorio";
            this.btQuitarAccesorio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "[Datos del Cliente]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "[Datos de la Venta]";
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(68, 136);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.ReadOnly = true;
            this.txPrecio.Size = new System.Drawing.Size(151, 20);
            this.txPrecio.TabIndex = 41;
            // 
            // txModelo
            // 
            this.txModelo.Location = new System.Drawing.Point(68, 110);
            this.txModelo.Name = "txModelo";
            this.txModelo.ReadOnly = true;
            this.txModelo.Size = new System.Drawing.Size(151, 20);
            this.txModelo.TabIndex = 40;
            // 
            // txTipo
            // 
            this.txTipo.Location = new System.Drawing.Point(68, 84);
            this.txTipo.Name = "txTipo";
            this.txTipo.ReadOnly = true;
            this.txTipo.Size = new System.Drawing.Size(151, 20);
            this.txTipo.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tipo:";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(352, 486);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(245, 20);
            this.lbTotal.TabIndex = 35;
            this.lbTotal.Text = "Total: $ 0,00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btAgregarAccesorio
            // 
            this.btAgregarAccesorio.Location = new System.Drawing.Point(1, 204);
            this.btAgregarAccesorio.Name = "btAgregarAccesorio";
            this.btAgregarAccesorio.Size = new System.Drawing.Size(200, 23);
            this.btAgregarAccesorio.TabIndex = 34;
            this.btAgregarAccesorio.Text = "Agregar Accesorio";
            this.btAgregarAccesorio.UseVisualStyleBackColor = true;
            this.btAgregarAccesorio.Click += new System.EventHandler(this.btAgregarAccesorio_Click_2);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btConfirmar.Location = new System.Drawing.Point(397, 513);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(200, 23);
            this.btConfirmar.TabIndex = 33;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Vehiculo:";
            // 
            // ddVehiculo
            // 
            this.ddVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddVehiculo.FormattingEnabled = true;
            this.ddVehiculo.Location = new System.Drawing.Point(68, 57);
            this.ddVehiculo.Name = "ddVehiculo";
            this.ddVehiculo.Size = new System.Drawing.Size(151, 21);
            this.ddVehiculo.TabIndex = 31;
            // 
            // gvAccesorios
            // 
            this.gvAccesorios.AllowUserToAddRows = false;
            this.gvAccesorios.AllowUserToDeleteRows = false;
            this.gvAccesorios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvAccesorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAccesorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Accesorio,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.gvAccesorios.Location = new System.Drawing.Point(1, 233);
            this.gvAccesorios.MultiSelect = false;
            this.gvAccesorios.Name = "gvAccesorios";
            this.gvAccesorios.ReadOnly = true;
            this.gvAccesorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAccesorios.Size = new System.Drawing.Size(596, 250);
            this.gvAccesorios.TabIndex = 30;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Accesorio
            // 
            this.Accesorio.DataPropertyName = "Accesorio";
            this.Accesorio.HeaderText = "Accesorio";
            this.Accesorio.Name = "Accesorio";
            this.Accesorio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // frmVentaNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 540);
            this.Controls.Add(this.btQuitarAccesorio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.txModelo);
            this.Controls.Add(this.txTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btAgregarAccesorio);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddVehiculo);
            this.Controls.Add(this.gvAccesorios);
            this.Name = "frmVentaNueva";
            this.Text = "frmVentaNueva";
            ((System.ComponentModel.ISupportInitialize)(this.gvAccesorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitarAccesorio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.TextBox txTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btAgregarAccesorio;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddVehiculo;
        private System.Windows.Forms.DataGridView gvAccesorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accesorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}