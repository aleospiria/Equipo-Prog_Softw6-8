using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class AsignaturasRepositorio
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
