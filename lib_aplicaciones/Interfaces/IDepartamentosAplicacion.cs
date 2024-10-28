using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_aplicaciones.Interfaces
{
    public interface IDepartamentosAplicacion
    {
        List<Departamentos> Listar();
        List<Departamentos> Buscar(Departamentos entidad, string tipo);
        Departamentos Guardar(Departamentos entidad);
        Departamentos Modificar(Departamentos entidad);
        Departamentos Borrar(Departamentos entidad);
    }
}
