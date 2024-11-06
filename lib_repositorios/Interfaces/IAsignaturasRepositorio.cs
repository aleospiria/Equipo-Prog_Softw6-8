using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IAsignaturasRepositorio
    {
        List<Asignaturas> Listar();
        List<Asignaturas> Buscar(Expression<Func<Asignaturas, bool>>condiciones);
        Asignaturas Guardar(Asignaturas entidad);
        Asignaturas Modificar(Asignaturas entidad);
        Asignaturas Borrar(Asignaturas entidad);
        void Configurar(string string_conexion);
    }
}
