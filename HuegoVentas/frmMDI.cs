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
            bool existe = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item is frmVendedores)
                {
                    existe = true;
                    item.BringToFront();
                    //item.Show();
                }

            }

            if (!existe)
            {

                frmVendedores f = new frmVendedores();
                f.MdiParent = this;

                f.Show();
            }
        }

		private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
		{
            bool existe = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item is frmVehiculos)
                {
                    existe = true;
                    item.BringToFront();
                    //item.Show();
                }

            }

            if (!existe)
            {

                frmVehiculos f = new frmVehiculos();
                f.MdiParent = this;

                f.Show();
            }
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool existe = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item is frmAccesorios)
                {
                    existe = true;
                    item.BringToFront();
                    //item.Show();
                }

            }

            if (!existe)
            {

                frmAccesorios f = new frmAccesorios();
                f.MdiParent = this;

                f.Show();
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool existe = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item is frmConsulta)
                {
                    existe = true;
                    item.BringToFront();
                    //item.Show();
                }

            }

            if (!existe)
            {

                frmConsulta f = new frmConsulta();
                f.MdiParent = this;

                f.Show();
            }
        }
    }
}
