using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class ProfesoresRepositorio : IProfesoresRepositorio
    {
        private Conexion? conexion = null;

        public ProfesoresRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Profesores> Listar()
        {
            return conexion!.Listar<Profesores>();
        }
        public List<Profesores> Buscar(Expression<Func<Profesores, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }
        public Profesores Guardar(Profesores entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Profesores Modificar(Profesores entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Profesores Borrar(Profesores entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
