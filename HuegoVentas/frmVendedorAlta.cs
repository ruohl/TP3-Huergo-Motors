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
    public partial class frmVendedorAlta : Form
    {
        private int vendedorId;

        public frmVendedorAlta()
        {
            InitializeComponent();
        }

        public void CargarVendedor(int id)
        {
            try
            {
                VendedorNegocio negocio = new VendedorNegocio();
                VendedorDTO vendedor = negocio.BuscarVendedor(id);
                if (vendedor != null)
                {
                    vendedorId = vendedor.Id;
                    txbID.Text = vendedorId.ToString();
                    txbNombre.Text = vendedor.Nombre;
                    txbApellido.Text = vendedor.Apellido;
                    txbSucursal.Text = vendedor.Sucursal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarVendedor()
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
                VendedorDTO vendedor = new VendedorDTO();
                vendedor.Id = vendedorId;
                vendedor.Nombre = txbNombre.Text;
                vendedor.Apellido = txbApellido.Text;
                vendedor.Sucursal = txbSucursal.Text;
                VendedorNegocio negocio = new VendedorNegocio();
                if (!string.IsNullOrWhiteSpace(vendedor.Nombre) && !string.IsNullOrWhiteSpace(vendedor.Apellido) && !string.IsNullOrWhiteSpace(vendedor.Sucursal))
                {
                    if (btCrear.Text == "Crear")
                    {
                        negocio.CrearVendedor(vendedor);
                    }
                    else
                    {
                        negocio.EditarVendedor(vendedor);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error", "Debe completar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
