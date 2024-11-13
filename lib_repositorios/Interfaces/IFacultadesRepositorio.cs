using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IFacultadesRepositorio
    {
        void Configurar(string string_conexion);
        List<Facultades> Listar();
        List<Facultades> Buscar(Expression<Func<Facultades, bool>> condiciones);
        Facultades Guardar(Facultades entidad);
        Facultades Modificar(Facultades entidad);
        Facultades Borrar(Facultades entidad);
    }
}
