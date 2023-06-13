using HuergoVentasDTO;
using HuergoVentasNegocio;
using System;
using System.Windows.Forms;

namespace HuegoVentas
{
    public partial class frmVehiculosAlta : Form
    {
        public frmVehiculosAlta()
        {
            InitializeComponent();
        }

        private int vehiculoId;

        public void CargarVehiculo(int id)
        {
            try
            {
                VehiculoNegocio negocio = new VehiculoNegocio();
                VehiculoDTO vehiculo = negocio.BuscarVehiculo(id);
                if (vehiculo != null)
                {
                    vehiculoId = vehiculo.Id;
                    txbID.Text = vehiculoId.ToString();
                    txbTipo.Text = vehiculo.Tipo;
                    txbModelo.Text = vehiculo.Modelo;
                    txbPrecioVenta.Text = vehiculo.PrecioVenta.ToString();
                    txbStock.Text = vehiculo.Stock.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarVehiculo()
        {
            try
            {
                btCrear.Text = "Guardar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            try
            {
                VehiculoDTO vehiculo = new VehiculoDTO();
                vehiculo.Id = Convert.ToInt32(vehiculoId);
                vehiculo.Tipo = txbTipo.Text;
                vehiculo.Modelo = txbModelo.Text;
                vehiculo.PrecioVenta = Convert.ToDecimal(txbPrecioVenta.Text);
                vehiculo.Stock = Convert.ToInt32(txbStock.Text);
                VehiculoNegocio negocio = new VehiculoNegocio();

                if (btCrear.Text == "Crear")
                {
                    negocio.CrearVehiculo(vehiculo);
                }
                else
                {
                    negocio.EditarVehiculo(vehiculo);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmVehiculosAlta_Load(object sender, EventArgs e)
        {
        }
    }
}   
