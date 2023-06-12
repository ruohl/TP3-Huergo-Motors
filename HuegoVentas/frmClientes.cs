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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            ClienteNegocio negocio = new ClienteNegocio();

            List<ClienteDTO> lista = negocio.BuscarClientes(txFiltro.Text);

            gvClientes.DataSource = lista;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmClienteAlta f = new frmClienteAlta();
            f.ShowDialog();
            ActualizarGrilla();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmClienteAlta f = new frmClienteAlta();
            if (gvClientes.SelectedRows.Count > 0)
            {
                object valor = gvClientes.SelectedRows[0].Cells["Id"].Value;

                int id = Convert.ToInt32(valor);

                f.CargarPersona(id);
                f.EditarClientes();
                f.ShowDialog();
                ActualizarGrilla(); // Actualizar la grilla después de cerrar
            }
            else
            {
                MessageBox.Show("No hay ninguna persona seleccionada", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

		private void btEliminar_Click(object sender, EventArgs e)
		{
            if (gvClientes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    object valor = gvClientes.SelectedRows[0].Cells["Id"].Value;
                    int id = Convert.ToInt32(valor);

                    ClienteNegocio negocio = new ClienteNegocio();
                    negocio.EliminarCliente(id);

                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún cliente seleccionado.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
	}
}
