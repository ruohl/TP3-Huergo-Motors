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
            try
            {
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGrilla()
        {
            try
            {
                VehiculoNegocio negocio = new VehiculoNegocio();
                List<VehiculoDTO> lista = negocio.BuscarVehiculos(txFiltro.Text);
                gvVehiculos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmVehiculosAlta f = new frmVehiculosAlta();
                f.ShowDialog();
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                frmVehiculosAlta f = new frmVehiculosAlta();
                if (gvVehiculos.SelectedRows.Count > 0)
                {
                    object valor = gvVehiculos.SelectedRows[0].Cells["Id"].Value;
                    int id = Convert.ToInt32(valor);
                    f.CargarVehiculo(id);
                    f.EditarVehiculo();
                    f.ShowDialog();
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("No hay ningun Vehiculo seleccionado", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
