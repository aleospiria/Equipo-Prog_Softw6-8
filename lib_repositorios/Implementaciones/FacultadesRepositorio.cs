using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class FacultadesRepositorio : IFacultadesRepositorio
    {
        private Conexion? conexion = null;

        public FacultadesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Facultades> Listar()
        {
            return conexion!.Listar<Facultades>();
        }
        public List<Facultades> Buscar(Expression<Func<Facultades, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }
        public Facultades Guardar(Facultades entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Facultades Modificar(Facultades entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Facultades Borrar(Facultades entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
