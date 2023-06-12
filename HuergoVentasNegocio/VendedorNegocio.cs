using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HuergoVentasDTO;
using HuergoVentasDatos;

namespace HuergoVentasNegocio
{
    public class VendedorNegocio
    {
        public void CrearVendedor(VendedorDTO vendedorDto)
        {
            VendedorDAO dao = new VendedorDAO();
            dao.Create(vendedorDto);
        }

        public void EditarVendedor(VendedorDTO vendedorDto)
        {
            VendedorDAO dao = new VendedorDAO();
            dao.Update(vendedorDto);
        }

        public VendedorNegocio()
        {
            VendedorDAO dao = new VendedorDAO();
            dao = new VendedorDAO();
        }

        public VendedorDTO BuscarVendedor(int id)
        {
            VendedorDAO dao = new VendedorDAO();
            string id2 = Convert.ToString(id);
            return dao.Read(id2);
        }

        public void EliminarVendedor(int id)
        {
            VendedorDAO dao = new VendedorDAO();
            dao.Delete(id);
        }

        public List<VendedorDTO> BuscarVendedores(string filtro)
        {
            VendedorDAO dao = new VendedorDAO();
            return dao.ReadAll(filtro);
        }       
    }
}
