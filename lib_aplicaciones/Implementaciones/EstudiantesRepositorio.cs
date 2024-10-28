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
    public class EstudiantesAplicacion : IEstudiantesAplicacion
    {
        private IEstudiantesRepositorio? iRepositorio = null;
        public EstudiantesAplicacion(IEstudiantesRepositorio
        iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }
        public Estudiantes Borrar(Estudiantes entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }
        public Estudiantes Guardar(Estudiantes entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");
            entidad = CalcularEstudiantes(entidad);
            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }
        public List<Estudiantes> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Estudiantes> Buscar(Estudiantes entidad, string
        tipo)
        {
            Expression<Func<Estudiantes, bool>>? condiciones =
            null;
            switch (tipo.ToUpper())
            {
                case "Nombre":
                    condiciones = x =>
                x.Nombre!.Contains(entidad.Nombre!); break;
                default:
                    condiciones = x => x.Id ==
                entidad.Id; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }
        public Estudiantes Modificar(Estudiantes entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = CalcularEstudiantes(entidad);
            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
        private Estudiantes CalcularEstudiantes(Estudiantes entidad)
        {

            return entidad;
        }
    }
}
