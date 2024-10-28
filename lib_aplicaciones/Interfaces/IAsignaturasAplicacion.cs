using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_aplicaciones.Interfaces
{
    public interface IAsignaturasAplicacion
    {
        List<Asignaturas> Listar();
        List<Asignaturas> Buscar(Asignaturas entidad, string tipo);
        Asignaturas Guardar(Asignaturas entidad);
        Asignaturas Modificar(Asignaturas entidad);
        Asignaturas Borrar(Asignaturas entidad);
    }
}
