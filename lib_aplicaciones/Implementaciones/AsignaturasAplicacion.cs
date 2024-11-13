using lib_entidades;
using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class AsignaturasAplicacion : IAsignaturasAplicacion
    {
        private IAsignaturasRepositorio? iRepositorio = null;

        public AsignaturasAplicacion(IAsignaturasRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Asignaturas Borrar(Asignaturas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Asignaturas Guardar(Asignaturas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Asignaturas> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Asignaturas> Buscar(Asignaturas entidad, string tipo)
        {
            Expression<Func<Asignaturas, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "NOMBRE": condiciones = x => x.NombreAsignatura!.Contains(entidad.NombreAsignatura!); break;
                case "DURACION": condiciones = x => x.Duracion!.Contains(entidad.Duracion!); break;
                case "COMPLEJA":
                    condiciones =
                        x => x.NombreAsignatura!.Contains(entidad.NombreAsignatura!) ||
                             x.Duracion!.Contains(entidad.Duracion!); break;
                default: condiciones = x => x.Id == entidad.Id; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Asignaturas Modificar(Asignaturas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
    }
}