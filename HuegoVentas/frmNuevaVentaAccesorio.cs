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
    public partial class frmVentaNuevaAccesorio : Form
    {
        public VentaItem item = new VentaItem();

        public frmVentaNuevaAccesorio()
        {
            InitializeComponent();
        }

        private void frmVentaNuevaAccesorio_Load(object sender, EventArgs e)
        {
            try
            {
                AccesorioNegocio negocio = new AccesorioNegocio();
                List<AccesorioDTO> list = negocio.GetAll();

                ddAccesorio.DisplayMember = "Nombre";
                ddAccesorio.ValueMember = "Id";
                ddAccesorio.DataSource = list;
            }
            catch (Exception ex)
            {
                FormsHelper.MsgError(ex);
            }
        }

        private void nuCantidad_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal precio = ((AccesorioDTO)ddAccesorio.SelectedItem).Precio;
                txPrecio.Text = precio.ToString("C2");
                txTotal.Text = (precio * nuCantidad.Value).ToString("C2");
            }
            catch (Exception ex)
            {
                FormsHelper.MsgError(ex);
            }
        }

        private void ddAccesorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal precio = ((AccesorioDTO)ddAccesorio.SelectedItem).Precio;
                txPrecio.Text = precio.ToString("C2");
                txTotal.Text = (precio * nuCantidad.Value).ToString("C2");
            }
            catch (Exception ex)
            {
                FormsHelper.MsgError(ex);
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Meto lo seleccionado en una variable publica para poder leerlo desde el llamador
                item.IdAccesorio = ((AccesorioDTO)ddAccesorio.SelectedItem).Id;
                item.Accesorio = ((AccesorioDTO)ddAccesorio.SelectedItem).Nombre;
                item.Modelo = ((AccesorioDTO)ddAccesorio.SelectedItem).Modelo;
                item.Precio = ((AccesorioDTO)ddAccesorio.SelectedItem).Precio;
                item.Cantidad = Convert.ToInt32(nuCantidad.Value);
                item.SubTotal = item.Precio * item.Cantidad;

                //Cierro el formulario con un 'Ok' para que continue desde el llamador
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                FormsHelper.MsgError(ex);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si cancelo, el item lo dejo en null porque no quiero hacer nada desde el llamador.
                item = null;

                //Cierro el formulario con un 'Cancel'
                DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                FormsHelper.MsgError(ex);
            }
        }

        private void txTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nuCantidad_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txTotal_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txPrecio_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ddAccesorio_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
