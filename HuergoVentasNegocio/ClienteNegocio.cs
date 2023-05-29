using HuergoVentasDatos;
using HuergoVentasDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuergoVentasNegocio
{
    public class ClienteNegocio
    {
        public void CrearCliente(ClienteDTO clienteDto)
        {
            ClienteDAO dao = new ClienteDAO();

            dao.Create(clienteDto);
        }

        public List<ClienteDTO> BuscarClientes(string filtro)
        {
            ClienteDAO dao = new ClienteDAO();

            return dao.ReadAll();
        }
    }
}
