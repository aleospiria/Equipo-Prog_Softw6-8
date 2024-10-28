using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IProfesoresRepositorio
    {
        List<Profesores> Listar();
        List<Profesores> Buscar(Expression<Func<Profesores, bool>> condiciones);
        Profesores Guardar(Profesores entidad);
        Profesores Modificar(Profesores entidad);
        Profesores Borrar(Profesores entidad);
    }
}
