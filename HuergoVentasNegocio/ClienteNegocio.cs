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

        public void EditarCliente(ClienteDTO clienteDto)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.Update(clienteDto);
        }

        public ClienteDTO BuscarCliente(int id)
        {
            ClienteDAO dao = new ClienteDAO();
            string id2 = Convert.ToString(id);
            return dao.Read(id2);
        }
        public void EliminarCliente(int id)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.Delete(id);
        }

        public List<ClienteDTO> BuscarClientes(string filtro)
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.ReadAll(filtro);
        }
    }
}