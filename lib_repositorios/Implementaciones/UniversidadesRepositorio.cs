using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class UniversidadesRepositorio : IUniversidadesRepositorio
    {
        private Conexion? conexion = null;

        public UniversidadesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Universidades> Listar()
        {
            return conexion!.Listar<Universidades>();
        }

        public List<Universidades> Buscar(Expression<Func<Universidades, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Universidades Guardar(Universidades entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Universidades Modificar(Universidades entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Universidades Borrar(Universidades entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}