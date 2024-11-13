using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class EstudiantesRepositorio
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
            return conexion!.Listar<Estudiantes>();
        }

        public List<Estudiantes> Buscar(Expression<Func<Estudiantes, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Estudiantes Guardar(Estudiantes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
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
