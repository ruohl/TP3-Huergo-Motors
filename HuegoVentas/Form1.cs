
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            HuergoVentasDTO.ClienteDTO cliente = new HuergoVentasDTO.ClienteDTO();
            ClienteDTO cliente2 = new ClienteDTO();



        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            HuergoVentasNegocio.ClienteNegocio negocio = new HuergoVentasNegocio.ClienteNegocio();

            ClienteDTO cliente = new ClienteDTO();

            cliente.Nombre = txNombre.Text;
            //cliente.Apellido = txApellido.Text;
            //Llenamos TODOS los campos

            negocio.CrearCliente(cliente);

        }
    }
}
