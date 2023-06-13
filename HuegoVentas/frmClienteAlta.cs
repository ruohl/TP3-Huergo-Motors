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
        private int clienteId;

        public frmClienteAlta()
        {
            InitializeComponent();
        }

        public void CargarPersona(int id)
        {
            try
            {
                ClienteNegocio negocio = new ClienteNegocio();
                ClienteDTO cliente = negocio.BuscarCliente(id);
                if (cliente != null)
                {
                    clienteId = cliente.Id;
                    txbID.Text = clienteId.ToString();
                    txbNombre.Text = cliente.Nombre;
                    txbDireccion.Text = cliente.Direccion;
                    txbTelefono.Text = cliente.Telefono;
                    txbEmail.Text = cliente.Email;
                    txbContraseña.Text = cliente.Contraseña;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarClientes()
        {
            btCrear.Text = "Guardar";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO cliente = new ClienteDTO();
                cliente.Id = clienteId;
                cliente.Nombre = txbNombre.Text;
                cliente.Direccion = txbDireccion.Text;
                cliente.Telefono = txbTelefono.Text;
                cliente.Email = txbEmail.Text;
                cliente.Contraseña = txbContraseña.Text;
                ClienteNegocio negocio = new ClienteNegocio();

                if (btCrear.Text == "Crear")
                {
                    negocio.CrearCliente(cliente);
                }
                else if (btCrear.Text == "Guardar") // Agregamos esta condición para editar
                {
                    negocio.EditarCliente(cliente);
                }
                else
                {
                    MessageBox.Show("Acción no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
