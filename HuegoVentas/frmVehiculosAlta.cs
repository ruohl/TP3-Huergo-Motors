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

        public void EditarVehiculo()
        {
            btCrear.Text = "Guardar";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
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

        private void frmVehiculosAlta_Load(object sender, EventArgs e)
        {

        }
    }
}
