using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_Presentaciones.Interfaces
{
    public interface IFacultadesPresentacion
    {
        Task<List<Facultades>> Listar();
        Task<List<Facultades>> Buscar(Facultades entidad, string tipo);
        Task<Facultades> Guardar(Facultades entidad);
        Task<Facultades> Modificar(Facultades entidad);
        Task<Facultades> Borrar(Facultades entidad);
    }
}
