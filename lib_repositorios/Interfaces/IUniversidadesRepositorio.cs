using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IUniversidadesRepositorio
    {
        void Configurar(string string_conexion);
        List<Universidades> Listar();
        List<Universidades> Buscar(Expression<Func<Universidades, bool>> condiciones);
        Universidades Guardar(Universidades entidad);
        Universidades Modificar(Universidades entidad);
        Universidades Borrar(Universidades entidad);
    }
}