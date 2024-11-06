using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using static lib_repositorios.Implementaciones.AsignaturasRepositorio;

namespace lib_repositorios.Implementaciones
{
    public class AsignaturasRepositorio : IAsignaturasRepositorio
    {
          private Conexion? conexion = null;
          public AsignaturasRepositorio(Conexion conexion)
          {
                this.conexion = conexion;
           }
          public void Configurar(string string_conexion)
         {
         this.conexion!.StringConnection = string_conexion;
        }

            public List<Asignaturas> Listar()
        {
            return conexion!.Listar<Asignaturas>();
        }
        public List<Asignaturas> Buscar(Expression<Func<Asignaturas, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }
        public Asignaturas Guardar(Asignaturas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Asignaturas Modificar(Asignaturas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Asignaturas Borrar(Asignaturas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
