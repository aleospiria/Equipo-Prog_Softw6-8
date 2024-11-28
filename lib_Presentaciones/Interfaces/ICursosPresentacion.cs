using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_Presentaciones.Interfaces
{
    public interface ICursosPresentacion
    {
        Task<List<Cursos>> Listar();
        Task<List<Cursos>> Buscar(Cursos entidad, string tipo);
        Task<Cursos> Guardar(Cursos entidad);
        Task<Cursos> Modificar(Cursos entidad);
        Task<Cursos> Borrar(Cursos entidad);
    }
}
