using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class CursosRepositorio : ICursosRepositorio
    {
        private Conexion? conexion = null;

        public CursosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Cursos> Listar()
        {
            return conexion!.Listar<Cursos>();
        }
        public List<Cursos> Buscar(Expression<Func<Cursos, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }
        public Cursos Guardar(Cursos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Cursos Modificar(Cursos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Cursos Borrar(Cursos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
