using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HuegoVentas
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //
            bool existe = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item is frmClientes)
                {
                    existe = true;
                    item.BringToFront();
                    //item.Show();
                }

            }

            if (!existe)
            {

                frmClientes f = new frmClientes();
                f.MdiParent = this;

                f.Show();
            }

        }

        private void vendoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedores f = new HuegoVentas.frmVendedores();
            f.MdiParent = this;
            f.Show();
        }
    }
}
