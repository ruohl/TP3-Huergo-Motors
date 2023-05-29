namespace HuegoVentas
{
    partial class Form1
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
            this.btGuardar = new System.Windows.Forms.Button();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGuardar.Location = new System.Drawing.Point(371, 239);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(116, 47);
            this.btGuardar.TabIndex = 0;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // txNombre
            // 
            this.txNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txNombre.Location = new System.Drawing.Point(136, 74);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(351, 22);
            this.txNombre.TabIndex = 1;
            // 
            // txApellido
            // 
            this.txApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txApellido.Location = new System.Drawing.Point(136, 102);
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(351, 22);
            this.txApellido.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 298);
            this.Controls.Add(this.txApellido);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.btGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txApellido;
    }
}

