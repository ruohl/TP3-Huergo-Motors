using HuergoVentasDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HuergoVentasDatos
{
    public class ClienteDAO
    {
        // CRUD
        // CREATE - READ - UPDATE - DELETE
        public void Create(ClienteDTO cliente)
        {
            // VA A CREAR UN CLIENTE EN LA DB
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(DAOHelper.ConnectionString))
            {
                conn.Open();

                string query = $@"INSERT INTO [Clientes] (Id, Nombre, Direccion, Telefono, Email, Contraseña) 
                                VALUES (
                                    (SELECT ISNULL(MAX(Id), 0) FROM Clientes) + 1, 
                                    '{cliente.Nombre}',
                                    '{cliente.Direccion}',
                                    '{cliente.Telefono}',
                                    '{cliente.Email}',
                                    '{cliente.Contraseña}');";

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

                string query = $"DELETE FROM Clientes WHERE Id = {id}";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(ClienteDTO cliente)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(DAOHelper.ConnectionString))
            {
                conn.Open();

                string query = $@"UPDATE [Clientes]
                                  SET Nombre = '{cliente.Nombre}',
                                      Direccion = '{cliente.Direccion}',
                                      Telefono = '{cliente.Telefono}',
                                      Email = '{cliente.Email}',
                                      Contraseña = '{cliente.Contraseña}'
                                WHERE Id = {cliente.Id};";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public ClienteDTO Read(string id)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                $"SELECT * FROM Clientes WHERE Id = {id}", DAOHelper.ConnectionString))
            {
                da.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                ClienteDTO cliente = new ClienteDTO();

                cliente.Id = Convert.ToInt32(dr["Id"]);
                cliente.Nombre = Convert.ToString(dr["Nombre"]);
                cliente.Direccion = Convert.ToString(dr["Direccion"]);
                cliente.Email = Convert.ToString(dr["Email"]);
                cliente.Contraseña = Convert.ToString(dr["Contraseña"]);
                cliente.Telefono = Convert.ToString(dr["Telefono"]);

                return cliente;
            }

            return null;
        }

        public List<ClienteDTO> ReadAll(string filtro)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                $"SELECT * FROM Clientes WHERE Nombre LIKE '%{filtro}%'", DAOHelper.ConnectionString))
            {
                da.Fill(dt);
            }

            List<ClienteDTO> lista = new List<ClienteDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                ClienteDTO cliente = new ClienteDTO();

                cliente.Id = Convert.ToInt32(dr["Id"]);
                cliente.Nombre = Convert.ToString(dr["Nombre"]);
                cliente.Direccion = Convert.ToString(dr["Direccion"]);
                cliente.Email = Convert.ToString(dr["Email"]);
                cliente.Contraseña = Convert.ToString(dr["Contraseña"]);
                cliente.Telefono = Convert.ToString(dr["Telefono"]);

                lista.Add(cliente);
            }

            return lista;
        }
    }
}