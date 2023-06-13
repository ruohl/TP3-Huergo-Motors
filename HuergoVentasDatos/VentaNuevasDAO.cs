using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HuergoVentasDTO;

namespace HuergoVentasDatos
{
    public class VentaNuevasDAO
    {
        private string connectionString;

        public VentaNuevasDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<VehiculoDTO> ObtenerVehiculos()
        {
            List<VehiculoDTO> vehiculos = new List<VehiculoDTO>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Modelo, Tipo, PrecioVenta FROM Vehiculos";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                VehiculoDTO vehiculo = new VehiculoDTO();
                                vehiculo.Id = Convert.ToInt32(row["Id"]);
                                vehiculo.Modelo = row["Modelo"].ToString();
                                vehiculo.Tipo = row["Tipo"].ToString();
                                vehiculo.PrecioVenta = Convert.ToDecimal(row["PrecioVenta"]);

                                vehiculos.Add(vehiculo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Console.WriteLine("Número de vehículos: " + vehiculos.Count);
            return vehiculos;
        }
    }
}
