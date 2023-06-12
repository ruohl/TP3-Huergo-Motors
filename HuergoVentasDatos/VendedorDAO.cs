using HuergoVentasDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HuergoVentasDatos
{
    public class VendedorDAO
    {
        public void Create(VendedorDTO vendedor)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(DAOHelper.ConnectionString))
            {
                conn.Open();

                string query = $@"INSERT INTO [Vendedores] (Id, Nombre, Apellido, Sucursal) 
                                VALUES (
                                    (SELECT ISNULL(MAX(Id), 0) FROM Vendedores) + 1, 
                                    '{vendedor.Nombre}',
                                    '{vendedor.Apellido}',
                                    '{vendedor.Sucursal}');";

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

                string query = $"DELETE FROM Vendedores WHERE Id = {id}";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Update(VendedorDTO vendedor)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(DAOHelper.ConnectionString))
            {
                conn.Open();

                string query = $@"UPDATE [Vendedores]
                                  SET Nombre = '{vendedor.Nombre}',
                                      Apellido = '{vendedor.Apellido}',
                                      Sucursal = '{vendedor.Sucursal}'
                                WHERE Id = {vendedor.Id};";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public VendedorDTO Read(string id)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                $"SELECT * FROM Vendedores WHERE Id = {id}", DAOHelper.ConnectionString))
            {
                da.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                VendedorDTO vendedor = new VendedorDTO();

                vendedor.Id = Convert.ToInt32(dr["Id"]);
                vendedor.Nombre = Convert.ToString(dr["Nombre"]);
                vendedor.Apellido = Convert.ToString(dr["Apellido"]);
                vendedor.Sucursal = Convert.ToString(dr["Sucursal"]);

                return vendedor;
            }

            return null;
        }

        public List<VendedorDTO> ReadAll(string filtro)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                $"SELECT * FROM Vendedores WHERE Nombre LIKE '%{filtro}%' or Apellido LIKE '%{filtro}%' ", DAOHelper.ConnectionString))
            {
                da.Fill(dt);
            }

            List<VendedorDTO> lista = new List<VendedorDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                VendedorDTO vendedor = new VendedorDTO();

                vendedor.Id = Convert.ToInt32(dr["Id"]);
                vendedor.Nombre = Convert.ToString(dr["Nombre"]);
                vendedor.Apellido = Convert.ToString(dr["Apellido"]);
                vendedor.Sucursal = Convert.ToString(dr["Sucursal"]);

                lista.Add(vendedor);
            }

            return lista;
        }




    }
}
