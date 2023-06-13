using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HuergoVentasDTO;
using HuergoVentasDatos;

namespace HuergoVentasNegocio
{
    public class AccesorioNegocio
    {
        public void CrearAccesorio(AccesorioDTO accesorioDto)
        {
            AccesorioDAO dao = new AccesorioDAO();
            dao.Create(accesorioDto);
        }

        public List<AccesorioDTO> GetAll()
        {
            AccesorioDAO dao = new AccesorioDAO();
            return dao.ReadAll();
        }

        public void EditarAccesorio(AccesorioDTO accesorioDto)
        {
            AccesorioDAO dao = new AccesorioDAO();
            dao.Update(accesorioDto);
        }

        public AccesorioNegocio()
        {
            AccesorioDAO dao = new AccesorioDAO();
            dao = new AccesorioDAO();
        }

        public AccesorioDTO BuscarAccesorio(int id)
        {
            AccesorioDAO dao = new AccesorioDAO();
            string id2 = Convert.ToString(id);
            return dao.Read(id2);
        }

        public void EliminarAccesorio(int id)
        {
            AccesorioDAO dao = new AccesorioDAO();
            dao.Delete(id);
        }

        public List<AccesorioDTO> BuscarAccesorios(string filtro)
        {
            AccesorioDAO dao = new AccesorioDAO();
            return dao.ReadAll(filtro);
        }
    }
}
