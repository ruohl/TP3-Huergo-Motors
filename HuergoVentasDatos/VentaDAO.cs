using HuergoVentasDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HuergoVentasDatos
{
    public class VentaDAO
    {
        public List<VentaModel> ReadAll(string filtro)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                $"select a.Nombre, b.Nombre, c.Modelo, d.Id, d.Fecha, d.IdVehiculo, d.IdCliente, d.IdVendedor, d.Observaciones, d.Total from Clientes a, Vendedores b, Vehiculos c, Ventas d", DAOHelper.ConnectionString))
            {
                da.Fill(dt);
            }

            List<VentaModel> lista = new List<VentaModel>();

            foreach (DataRow dr in dt.Rows)
            {
                VentaModel venta = new VentaModel();

                venta.Cliente = Convert.ToString(dr["Cliente"]);
                venta.Vendedor = Convert.ToString(dr["Vendedor"]);
                venta.Vehiculo = Convert.ToString(dr["Vehiculo"]);
                venta.Id = Convert.ToInt32(dr["Id"]);
                venta.Fecha = Convert.ToDateTime(dr["Fecha"]);
                venta.IdVehiculo = Convert.ToInt32(dr["IdVehiculo"]);
                venta.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                venta.IdVendedor = Convert.ToInt32(dr["IdVendedor"]);
                venta.Observaciones = Convert.ToString(dr["Observaciones"]);
                venta.Total = Convert.ToDecimal(dr["Total"]);

                lista.Add(venta);
            }

            return lista;
        }
    }
}
