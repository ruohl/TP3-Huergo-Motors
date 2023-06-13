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
        //Creo una clase 'VentaItem' para contener toda la informacion que quiero mostrar en la grilla de items
        List<VentaItem> items = new List<VentaItem>();

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

                        //Recargo la grilla
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

        }

        private void frmVentaNueva_Load(object sender, EventArgs e)
        {
            gvAccesorios.AutoGenerateColumns = false;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void ddVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void btQuitarAccesorio_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gvAccesorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAgregarAccesorio_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (gvAccesorios.SelectedRows.Count == 1)
                {
                    items.Remove((VentaItem)gvAccesorios.SelectedRows[0].DataBoundItem);

                    //Recargo la grilla
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
    }
}
