using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_aplicaciones.Interfaces
{
    public interface IFacultadesAplicacion
    {
        List<Facultades> Listar();
        List<Facultades> Buscar(Facultades entidad, string tipo);
        Facultades Guardar(Facultades entidad);
        Facultades Modificar(Facultades entidad);
        Facultades Borrar(Facultades entidad);
    }
}
