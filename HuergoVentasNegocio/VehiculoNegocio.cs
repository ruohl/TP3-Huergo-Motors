using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HuergoVentasDTO;
using HuergoVentasDatos;

namespace HuergoVentasNegocio
{
    public class VehiculoNegocio
    {
        public void CrearVehiculo(VehiculoDTO vehiculoDto)
        {
            VehiculoDAO dao = new VehiculoDAO();
            dao.Create(vehiculoDto);
        }

        public void EditarVehiculo(VehiculoDTO vehiculoDto)
        {
            VehiculoDAO dao = new VehiculoDAO();
            dao.Update(vehiculoDto);
        }

        public VehiculoNegocio()
        {
            VehiculoDAO dao = new VehiculoDAO();
            dao = new VehiculoDAO();
        }

        public VehiculoDTO BuscarVehiculo(int id)
        {
            VehiculoDAO dao = new VehiculoDAO();
            string id2 = Convert.ToString(id);
            return dao.Read(id2);
        }

        public void EliminarVehiculo(int id)
        {
            VehiculoDAO dao = new VehiculoDAO();
            dao.Delete(id);
        }

        public List<VehiculoDTO> BuscarVehiculos(string filtro)
        {
            VehiculoDAO dao = new VehiculoDAO();
            return dao.ReadAll(filtro);
        }
    }
}
