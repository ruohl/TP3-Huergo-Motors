using HuergoVentasDTO;
using HuergoVentasNegocio;
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
    public partial class frmVendedores : Form
    {
        public frmVendedores()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            VendedorNegocio negocio = new VendedorNegocio();
            List<VendedorDTO> lista = negocio.BuscarVendedores(txFiltro.Text);
            gvVendedores.DataSource = lista;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmVendedorAlta f = new frmVendedorAlta();
            f.ShowDialog();
            ActualizarGrilla();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmVendedorAlta f = new frmVendedorAlta();
            if (gvVendedores.SelectedRows.Count > 0)
            {
                object valor = gvVendedores.SelectedRows[0].Cells["Id"].Value;
                int id = Convert.ToInt32(valor);
                f.CargarVendedor(id);
                f.EditarVendedor();
                f.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("No hay ningún vendedor seleccionado", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (gvVendedores.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este vendedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    object valor = gvVendedores.SelectedRows[0].Cells["Id"].Value;
                    int id = Convert.ToInt32(valor);
                    VendedorNegocio negocio = new VendedorNegocio();
                    negocio.EliminarVendedor(id);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún vendedor seleccionado", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

	}
}
