﻿using HuergoVentasDTO;
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
	public partial class frmAccesorios : Form
	{
        public frmAccesorios()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            AccesorioNegocio negocio = new AccesorioNegocio();

            List<AccesorioDTO> lista = negocio.BuscarAccesorios(txFiltro.Text);

            gvAccesorios.DataSource = lista;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmAccesoriosAlta f = new frmAccesoriosAlta();
            f.ShowDialog();
            ActualizarGrilla();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmAccesoriosAlta f = new frmAccesoriosAlta();
            if (gvAccesorios.SelectedRows.Count > 0)
            {
                object valor = gvAccesorios.SelectedRows[0].Cells["Id"].Value;

                int id = Convert.ToInt32(valor);

                f.CargarAccesorio(id);
                f.EditarAccesorio();
                f.ShowDialog();
                ActualizarGrilla(); // Actualizar la grilla después de cerrar
            }
            else
            {
                MessageBox.Show("No hay ninguna persona seleccionada", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (gvAccesorios.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    object valor = gvAccesorios.SelectedRows[0].Cells["Id"].Value;
                    int id = Convert.ToInt32(valor);

                    AccesorioNegocio negocio = new AccesorioNegocio();
                    negocio.EliminarAccesorio(id);

                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún cliente seleccionado.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btNuevo_Click_1(object sender, EventArgs e)
        {

        }

		private void frmAccesorios_Load(object sender, EventArgs e)
		{
            ActualizarGrilla();
        }
	}
}
