namespace HuegoVentas
{
    partial class frmMDI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vendoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnClientes = new System.Windows.Forms.ToolStripMenuItem();
			this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 555);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
			this.statusStrip1.Size = new System.Drawing.Size(938, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem,
            this.ventaToolStripMenuItem,
            this.btnSalir});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(938, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aBMToolStripMenuItem
			// 
			this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendoresToolStripMenuItem,
            this.btnClientes,
            this.articulosToolStripMenuItem,
            this.vehiculosToolStripMenuItem});
			this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
			this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.aBMToolStripMenuItem.Text = "ABM";
			// 
			// vendoresToolStripMenuItem
			// 
			this.vendoresToolStripMenuItem.Name = "vendoresToolStripMenuItem";
			this.vendoresToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.vendoresToolStripMenuItem.Text = "Vendores";
			this.vendoresToolStripMenuItem.Click += new System.EventHandler(this.vendoresToolStripMenuItem_Click);
			// 
			// btnClientes
			// 
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(131, 22);
			this.btnClientes.Text = "Clientes";
			this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
			// 
			// articulosToolStripMenuItem
			// 
			this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
			this.articulosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.articulosToolStripMenuItem.Text = "Accesorios";
			this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
			// 
			// vehiculosToolStripMenuItem
			// 
			this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
			this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.vehiculosToolStripMenuItem.Text = "Vehiculos";
			this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
			// 
			// ventaToolStripMenuItem
			// 
			this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.consultaToolStripMenuItem});
			this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
			this.ventaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.ventaToolStripMenuItem.Text = "Venta";
			// 
			// nuevaToolStripMenuItem
			// 
			this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
			this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.nuevaToolStripMenuItem.Text = "Nueva";
			// 
			// consultaToolStripMenuItem
			// 
			this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
			this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.consultaToolStripMenuItem.Text = "Consulta";
			this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(41, 20);
			this.btnSalir.Text = "Salir";
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(938, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// frmMDI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 577);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmMDI";
			this.Text = "Huergo Motors";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnClientes;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
    }
}