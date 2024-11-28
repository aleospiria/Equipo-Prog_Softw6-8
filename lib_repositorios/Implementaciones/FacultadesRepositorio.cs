using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Facultades> Listar()
        {
            return Buscar(x => x != null);
        }
        public List<Facultades> Buscar(Expression<Func<Facultades, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }
        public Facultades Guardar(Facultades entidad)
        {
            try
            {
                conexion!.Guardar(entidad);
                conexion!.GuardarCambios();
                return entidad;
            }
            catch (DbUpdateException ex) { throw new Exception("Error al actualizar la base de datos: " + ex.InnerException?.Message); }
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
