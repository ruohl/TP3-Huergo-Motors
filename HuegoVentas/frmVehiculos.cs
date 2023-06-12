using HuergoVentasDTO;
using HuergoVentasNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HuegoVentas
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            VehiculoNegocio negocio = new VehiculoNegocio();

            List<VehiculoDTO> lista = negocio.BuscarVehiculos(txFiltro.Text);

            gvVehiculos.DataSource = lista;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmVehiculosAlta f = new frmVehiculosAlta();
            f.ShowDialog();
            ActualizarGrilla();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmVehiculosAlta f = new frmVehiculosAlta();
            if (gvVehiculos.SelectedRows.Count > 0)
            {
                object valor = gvVehiculos.SelectedRows[0].Cells["Id"].Value;

                int id = Convert.ToInt32(valor);

                f.CargarVehiculo(id);
                f.EditarVehiculo();
                f.ShowDialog();
                ActualizarGrilla(); // Actualizar la grilla después de cerrar
            }
            else
            {
                MessageBox.Show("No hay ningun Vehiculo seleccionado", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (gvVehiculos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este Vehiculo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    object valor = gvVehiculos.SelectedRows[0].Cells["Id"].Value;
                    int id = Convert.ToInt32(valor);

                    VehiculoNegocio negocio = new VehiculoNegocio();
                    negocio.EliminarVehiculo(id);

                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún Vehiculo seleccionado.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

		private void btBuscar_Click_1(object sender, EventArgs e)
		{

		}

        private void frmVehiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
