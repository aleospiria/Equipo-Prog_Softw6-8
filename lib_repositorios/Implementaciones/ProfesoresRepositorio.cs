using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Profesores> Listar()
        {
            return Buscar(x => x != null);
        }
        public List<Profesores> Buscar(Expression<Func<Profesores, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }
        public Profesores Guardar(Profesores entidad)
        {
            try
            {
                conexion!.Guardar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }
            catch (DbUpdateException ex) { throw new Exception("Error al actualizar la base de datos: " + ex.InnerException?.Message); }
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
