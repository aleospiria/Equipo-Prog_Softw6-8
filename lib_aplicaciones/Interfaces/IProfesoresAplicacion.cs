using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_aplicaciones.Interfaces
{
    public interface IProfesoresAplicacion
    {
        List<Profesores> Listar();
        List<Profesores> Buscar(Profesores entidad, string tipo);
        Profesores Guardar(Profesores entidad);
        Profesores Modificar(Profesores entidad);
        Profesores Borrar(Profesores entidad);
    }
}
