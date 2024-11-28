using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Cursos> Listar()
        {
            return Buscar(x => x != null);
        }
        public List<Cursos> Buscar(Expression<Func<Cursos, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }
        public Cursos Guardar(Cursos entidad)
        {
            try
            {
                conexion!.Guardar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }
            catch (DbUpdateException ex) { throw new Exception("Error al actualizar la base de datos: " + ex.InnerException?.Message); }
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
