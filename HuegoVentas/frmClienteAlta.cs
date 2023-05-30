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
    public partial class frmClienteAlta : Form
    {
        public frmClienteAlta()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            ClienteDTO cliente = new ClienteDTO();
            cliente.Nombre = txbNombre.Text;
            cliente.Direccion = txbDireccion.Text;
            cliente.Telefono = txbTelefono.Text;
            cliente.Email = txbEmail.Text;
            cliente.Contraseña = txbContraseña.Text;
            ClienteNegocio negocio = new ClienteNegocio();
            negocio.CrearCliente(cliente);
            this.Close();
        }
    }
}
