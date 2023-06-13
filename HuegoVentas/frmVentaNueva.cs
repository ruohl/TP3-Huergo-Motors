using HuergoVentasDatos;
using HuergoVentasDTO;
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
    public partial class frmVentaNueva : Form
    {
        private List<VentaItem> items = new List<VentaItem>();

        public frmVentaNueva()
        {
            InitializeComponent();
        }

        private void btAgregarAccesorio_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmVentaNuevaAccesorio f = new frmVentaNuevaAccesorio())
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        items.Add(f.item);
                        gvAccesorios.DataSource = null;
                        gvAccesorios.DataSource = items;
                        decimal total = items.Sum(x => x.SubTotal);
                        lbTotal.Text = "Total: " + total.ToString("C2");
                    }
                }
            }
            catch (Exception ex)
            {
                FormsHelper.MsgError(ex);
            }
        }

        private void btQuitarAccesorio_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvAccesorios.SelectedRows.Count == 1)
                {
                    items.Remove((VentaItem)gvAccesorios.SelectedRows[0].DataBoundItem);
                    gvAccesorios.DataSource = null;
                    gvAccesorios.DataSource = items;
                    decimal total = items.Sum(x => x.SubTotal);
                    lbTotal.Text = "Total: " + total.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                FormsHelper.MsgError(ex);
            }
        }

        private void CargarVehiculos()
        {
            try
            {
                VentaNuevasDAO ventaNuevasDAO = new VentaNuevasDAO(DAOHelper.ConnectionString);
                List<VehiculoDTO> vehiculos = ventaNuevasDAO.ObtenerVehiculos();

                ddVehiculo.DataSource = vehiculos;
                ddVehiculo.DisplayMember = "Modelo";
                ddVehiculo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ddVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddVehiculo.SelectedItem is VehiculoDTO vehiculo)
            {
                txTipo.Text = vehiculo.Tipo;
                txModelo.Text = vehiculo.Modelo;
                txPrecio.Text = vehiculo.PrecioVenta.ToString();
            }
            else
            {
                txTipo.Text = string.Empty;
                txModelo.Text = string.Empty;
                txPrecio.Text = string.Empty;
            }
        }

		private void frmVentaNueva_Load_1(object sender, EventArgs e)
		{
            CargarVehiculos();
            gvAccesorios.AutoGenerateColumns = false;
        }
	}
}
