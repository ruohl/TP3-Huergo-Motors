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

namespace HuergoVentas
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

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
                VentaNegocio negocio = new VentaNegocio();

                List<VentaModel> lista = negocio.BuscarVenta(txFiltro.Text);

                gvClientes.DataSource = lista;
            }
        }
    }
