using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_Presentaciones.Interfaces
{
    public interface IAsignaturasPresentacion
    {
        Task<List<Asignaturas>> Listar();
        Task<List<Asignaturas>> Buscar(Asignaturas entidad, string tipo);
        Task<Asignaturas> Guardar(Asignaturas entidad);
        Task<Asignaturas> Modificar(Asignaturas entidad);
        Task<Asignaturas> Borrar(Asignaturas entidad);
    }
}
