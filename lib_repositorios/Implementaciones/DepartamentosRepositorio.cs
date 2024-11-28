using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class DepartamentosRepositorio : IDepartamentosRepositorio
    {
        private Conexion? conexion = null;

        public DepartamentosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }
        public List<Departamentos> Listar()
        {
            return Buscar(x => x != null);
        }
        public List<Departamentos> Buscar(Expression<Func<Departamentos, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }
        public Departamentos Guardar(Departamentos entidad)
        {
            try
            {
                conexion!.Guardar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }
            catch (DbUpdateException ex) { throw new Exception("Error al actualizar la base de datos: " + ex.InnerException?.Message); }
        }

        public Departamentos Modificar(Departamentos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Departamentos Borrar(Departamentos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
