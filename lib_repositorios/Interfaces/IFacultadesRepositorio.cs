using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IFacultadesRepositorio
    {
        List<Facultades> Listar();
        List<Facultades> Buscar(Expression<Func<Facultades, bool>> condiciones);
        Facultades Guardar(Facultades entidad);
        Facultades Modificar(Facultades entidad);
        Facultades Borrar(Facultades entidad);
    }
}