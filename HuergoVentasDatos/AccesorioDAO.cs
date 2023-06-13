﻿using HuergoVentasDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HuergoVentasDatos
{
    public class AccesorioDAO
    {
        public List<AccesorioDTO> ReadAll()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                "SELECT * FROM Accesorios", DAOHelper.ConnectionString))
            {
                da.Fill(dt);
            }

            List<AccesorioDTO> lista = new List<AccesorioDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                AccesorioDTO cliente = new AccesorioDTO();

                cliente.Id = Convert.ToInt32(dr["Id"]);
                cliente.Nombre = Convert.ToString(dr["Nombre"]);
                cliente.Modelo = Convert.ToString(dr["Modelo"]);
                cliente.Precio = Convert.ToDecimal(dr["Precio"]);

                lista.Add(cliente);
            }

            return lista;
        }
        public void Create(AccesorioDTO accesorio)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(DAOHelper.ConnectionString))
            {
                conn.Open();

                string query = $@"INSERT INTO [Accesorios] (Id, Nombre, Modelo, Precio) 
                                VALUES (
                                    (SELECT ISNULL(MAX(Id), 0) FROM Clientes) + 1, 
                                    '{accesorio.Nombre}',
                                    '{accesorio.Modelo}',
                                    '{accesorio.Precio}');";

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

                string query = $"DELETE FROM Accesorios WHERE Id = {id}";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(AccesorioDTO accesorio)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(DAOHelper.ConnectionString))
            {
                conn.Open();

                string query = $@"UPDATE [Accesorios]
                                  SET Nombre = '{accesorio.Nombre}',
                                      Modelo = '{accesorio.Modelo}',
                                      Precio = '{accesorio.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture)}'
                                WHERE Id = {accesorio.Id};";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public AccesorioDTO Read(string id)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                $"SELECT * FROM Accesorios WHERE Id = {id}", DAOHelper.ConnectionString))
            {
                da.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                AccesorioDTO accesorio = new AccesorioDTO();

                accesorio.Id = Convert.ToInt32(dr["Id"]);
                accesorio.Nombre = Convert.ToString(dr["Nombre"]);
                accesorio.Modelo = Convert.ToString(dr["Modelo"]);
                accesorio.Precio = Convert.ToDecimal(dr["Precio"]);

                return accesorio;
            }

            return null;
        }

        public List<AccesorioDTO> ReadAll(string filtro)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                $"SELECT * FROM Accesorios WHERE Nombre LIKE '%{filtro}%' or Modelo LIKE '%{filtro}%'", DAOHelper.ConnectionString))
            {
                da.Fill(dt);
            }

            List<AccesorioDTO> lista = new List<AccesorioDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                AccesorioDTO accesorio = new AccesorioDTO();

                accesorio.Id = Convert.ToInt32(dr["Id"]);
                accesorio.Nombre = Convert.ToString(dr["Nombre"]);
                accesorio.Modelo = Convert.ToString(dr["Modelo"]);
                accesorio.Precio = Convert.ToDecimal(dr["Precio"]);

                lista.Add(accesorio);
            }

            return lista;
        }
    }
}