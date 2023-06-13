using HuergoVentasDatos;
using HuergoVentasDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuergoVentasNegocio
{
    public class VentaNegocio
    {
        public List<VentaModel> BuscarVenta(string filtro)
        {
            VentaDAO dao = new VentaDAO();
            return dao.ReadAll(filtro);
        }
    }
}
