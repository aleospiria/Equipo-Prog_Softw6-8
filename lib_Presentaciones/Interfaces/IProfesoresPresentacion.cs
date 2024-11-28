using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_Presentaciones.Interfaces
{
    public interface IProfesoresPresentacion
    {
        Task<List<Profesores>> Listar();
        Task<List<Profesores>> Buscar(Profesores entidad, string tipo);
        Task<Profesores> Guardar(Profesores entidad);
        Task<Profesores> Modificar(Profesores entidad);
        Task<Profesores> Borrar(Profesores entidad);
    }
}
