using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IEstudiantesRepositorio
    {
        List<Estudiantes> Listar();
        List<Estudiantes> Buscar(Expression<Func<Estudiantes, bool>> condiciones);
        Estudiantes Guardar(Estudiantes entidad);
        Estudiantes Modificar(Estudiantes entidad);
        Estudiantes Borrar(Estudiantes entidad);
    }
}
