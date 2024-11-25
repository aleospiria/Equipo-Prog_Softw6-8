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
    public class CursosAplicacion : ICursosAplicacion
    {
        private ICursosRepositorio? iRepositorio = null;
        public CursosAplicacion(ICursosRepositorio
        iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }
        public Cursos Borrar(Cursos entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }
        public Cursos Guardar(Cursos entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");
            entidad = CalcularCursos(entidad);
            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }
        public List<Cursos> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Cursos> Buscar(Cursos entidad, string
        tipo)
        {
            Expression<Func<Cursos, bool>>? condiciones =
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
        public Cursos Modificar(Cursos entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = CalcularCursos(entidad);
            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
        private Cursos CalcularCursos(Cursos entidad)
        {

            return entidad;
        }
    }
}
