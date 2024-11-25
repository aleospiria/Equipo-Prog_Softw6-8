using lib_aplicaciones.Interfaces;
using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }
        public Asignaturas Guardar(Asignaturas entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");
            entidad = CalcularAsignaturas(entidad);
            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }
        public List<Asignaturas> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Asignaturas> Buscar(Asignaturas entidad, string
        tipo)
        {
            Expression<Func<Asignaturas, bool>>? condiciones =
            null;
            switch (tipo.ToUpper())
            {
                case "Codigo Asignatura":
                    condiciones = x =>
                x.Codigo!.Contains(entidad.Codigo!); break;
                case "Nombre Asignatura":
                    condiciones = x => x.Nombre!.Contains(entidad.Nombre!);
                    break;
                default:
                    condiciones = x => x.Id ==
                entidad.Id; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Asignaturas BuscarId(int id)
        {
            Expression<Func<Asignaturas, bool>> condicion =x => x.Id == id;
            return this.iRepositorio!.Buscar(condicion).FirstOrDefault();
        }

        public Asignaturas Modificar(Asignaturas entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = CalcularAsignaturas(entidad);
            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
        private Asignaturas CalcularAsignaturas(Asignaturas entidad)
        {

            return entidad;
        }

    }
}
