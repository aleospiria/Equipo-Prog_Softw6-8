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
        void Configurar(string string_conexion);
        List<Asignaturas> Listar();
        List<Asignaturas> Buscar(Asignaturas entidad, string tipo);
        Asignaturas BuscarId(int id);
        Asignaturas Guardar(Asignaturas entidad);
        Asignaturas Modificar(Asignaturas entidad);
        Asignaturas Borrar(Asignaturas entidad);
    }
}
