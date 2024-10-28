using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IDepartamentosRepositorio
    {
        List<Departamentos> Listar();
        List<Departamentos> Buscar(Expression<Func<Departamentos, bool>> condiciones);
        Departamentos Guardar(Departamentos entidad);
        Departamentos Modificar(Departamentos entidad);
        Departamentos Borrar(Departamentos entidad);
    }
}
