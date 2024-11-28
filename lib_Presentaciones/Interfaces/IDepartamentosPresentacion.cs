using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_Presentaciones.Interfaces
{
    public interface IDepartamentosPresentacion
    {
        Task<List<Departamentos>> Listar();
        Task<List<Departamentos>> Buscar(Departamentos entidad, string tipo);
        Task<Departamentos> Guardar(Departamentos entidad);
        Task<Departamentos> Modificar(Departamentos entidad);
        Task<Departamentos> Borrar(Departamentos entidad);
    }
}
