using HuergoVentasDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HuergoVentasDatos
{
	public class VehiculoDAO
	{
        public void Create(VehiculoDTO vehiculo)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(DAOHelper.ConnectionString))
            {
                conn.Open();

                string query = $@"INSERT INTO [Vehiculos] (Id, Tipo, Modelo, PrecioVenta, Stock) 
                                VALUES (
                                    (SELECT ISNULL(MAX(Id), 0) FROM Vendedores) + 1, 
                                    '{vehiculo.Tipo}',
                                    '{vehiculo.Modelo}',
                                    '{vehiculo.PrecioVenta}',
                                    '{vehiculo.Stock}');";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Delete(int id)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(DAOHelper.ConnectionString))
            {
                conn.Open();

                string query = $"DELETE FROM Vehiculos WHERE Id = {id}";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Update(VehiculoDTO vehiculo)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(DAOHelper.ConnectionString))
            {
                conn.Open();

                string query = @"UPDATE [Vehiculos]
                        SET Tipo = @Tipo,
                            Modelo = @Modelo,
                            PrecioVenta = @PrecioVenta,
                            Stock = @Stock
                        WHERE Id = @Id;";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tipo", vehiculo.Tipo);
                    cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                    cmd.Parameters.AddWithValue("@PrecioVenta", vehiculo.PrecioVenta);
                    cmd.Parameters.AddWithValue("@Stock", vehiculo.Stock);
                    cmd.Parameters.AddWithValue("@Id", vehiculo.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public VehiculoDTO Read(string id)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                $"SELECT * FROM Vehiculos WHERE Id = {id}", DAOHelper.ConnectionString))
            {
                da.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                VehiculoDTO vehiculo = new VehiculoDTO();
                vehiculo.Id = Convert.ToInt32(dr["Id"]);
                vehiculo.Modelo = Convert.ToString(dr["Modelo"]);
                vehiculo.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                vehiculo.Stock = Convert.ToInt32(dr["Stock"]);

                return vehiculo;
            }

            return null;
        }

        public List<VehiculoDTO> ReadAll(string filtro)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                $"SELECT * FROM Vehiculos WHERE Modelo LIKE '%{filtro}%'", DAOHelper.ConnectionString))
            {
                da.Fill(dt);
            }

            List<VehiculoDTO> lista = new List<VehiculoDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                VehiculoDTO vehiculo = new VehiculoDTO();
                vehiculo.Id = Convert.ToInt32(dr["Id"]);
                vehiculo.Modelo = Convert.ToString(dr["Modelo"]);
                vehiculo.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                vehiculo.Stock = Convert.ToInt32(dr["Stock"]);
                lista.Add(vehiculo);
            }

            return lista;
        }
    }
}
