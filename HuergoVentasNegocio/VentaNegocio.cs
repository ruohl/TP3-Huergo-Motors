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
            VentaNuevaDAO dao = new VentaNuevaDAO();
            return dao.ReadAll(filtro);
        }
    }
}
