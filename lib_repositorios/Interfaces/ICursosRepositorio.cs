using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ICursosRepositorio
    {
        List<Cursos> Listar();
        List<Cursos> Buscar(Expression<Func<Cursos, bool>> condiciones);
        Cursos Guardar(Cursos entidad);
        Cursos Modificar(Cursos entidad);
        Cursos Borrar(Cursos entidad);
    }
}