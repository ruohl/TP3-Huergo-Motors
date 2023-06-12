using HuergoVentasDTO;
using HuergoVentasNegocio;
using System;
using System.Windows.Forms;

namespace HuegoVentas
{
    public partial class frmAccesoriosAlta : Form
    {
        public frmAccesoriosAlta()
        {
            InitializeComponent();
        }

        private int accesorioId;

        public void CargarAccesorio(int id)
        {
            AccesorioNegocio negocio = new AccesorioNegocio();
            AccesorioDTO accesorio = negocio.BuscarAccesorio(id);
            if (accesorio != null)
            {
                accesorioId = accesorio.Id;
                txbID.Text = accesorioId.ToString();
                txbNombre.Text = accesorio.Modelo;
                txbPrecio.Text = accesorio.Precio.ToString();
                txbNombre.Text = accesorio.Nombre;
            }

        }

        public void EditarAccesorio()
        {
            btCrear.Text = "Guardar";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            AccesorioDTO accesorio = new AccesorioDTO();
            accesorio.Id = Convert.ToInt32(accesorioId);
            accesorio.Modelo = txbNombre.Text;
            accesorio.Nombre = txbNombre.Text;
            accesorio.Precio = Convert.ToDecimal(txbPrecio.Text);
            AccesorioNegocio negocio = new AccesorioNegocio();

            if (btCrear.Text == "Crear")
            {
                negocio.CrearAccesorio(accesorio);
            }
            else
            {
                negocio.EditarAccesorio(accesorio);
            }

            this.Close();
        }

        private void frmAccesoriosAlta_Load(object sender, EventArgs e)
        {

        }

        private void lbTipo_Click(object sender, EventArgs e)
        {

        }
    }
}