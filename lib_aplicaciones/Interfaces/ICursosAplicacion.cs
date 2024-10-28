using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_aplicaciones.Interfaces
{
    public interface ICursosAplicacion
    {
        List<Cursos> Listar();
        List<Cursos> Buscar(Cursos entidad, string tipo);
        Cursos Guardar(Cursos entidad);
        Cursos Modificar(Cursos entidad);
        Cursos Borrar(Cursos entidad);
    }
}
