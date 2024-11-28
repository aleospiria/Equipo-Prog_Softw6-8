using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class EstudiantesRepositorio : IEstudiantesRepositorio
    {
        private Conexion? conexion = null;

        public EstudiantesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }
        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Estudiantes> Listar()
        {
            return Buscar(x => x != null);
        }
        public List<Estudiantes> Buscar(Expression<Func<Estudiantes, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }
        public Estudiantes Guardar(Estudiantes entidad)
        {
            try
            {
                conexion!.Guardar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }
            catch (DbUpdateException ex) { throw new Exception("Error al actualizar la base de datos: " + ex.InnerException?.Message); }
        }

        public Estudiantes Modificar(Estudiantes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Estudiantes Borrar(Estudiantes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
