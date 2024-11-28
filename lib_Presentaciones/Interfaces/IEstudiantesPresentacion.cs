using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_Presentaciones.Interfaces
{
    public interface IEstudiantesPresentacion
    {
        Task<List<Estudiantes>> Listar();
        Task<List<Estudiantes>> Buscar(Estudiantes entidad, string tipo);
        Task<Estudiantes> Guardar(Estudiantes entidad);
        Task<Estudiantes> Modificar(Estudiantes entidad);
        Task<Estudiantes> Borrar(Estudiantes entidad);
    }
}
