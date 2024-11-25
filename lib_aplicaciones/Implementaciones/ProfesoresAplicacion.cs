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
    public class ProfesoresAplicacion : IProfesoresAplicacion
    {
        private IProfesoresRepositorio? iRepositorio = null;
        public ProfesoresAplicacion(IProfesoresRepositorio
        iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }
        public Profesores Borrar(Profesores entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }
        public Profesores Guardar(Profesores entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");
            entidad = CalcularProfesores(entidad);
            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }
        public List<Profesores> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Profesores> Buscar(Profesores entidad, string
        tipo)
        {
            Expression<Func<Profesores, bool>>? condiciones =
            null;
            switch (tipo.ToUpper())
            {
                case "Nombre":
                    condiciones = x =>
                x.Nombres!.Contains(entidad.Nombres!); break;
                default:
                    condiciones = x => x.Id ==
                entidad.Id; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }
        public Profesores Modificar(Profesores entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = CalcularProfesores(entidad);
            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
        private Profesores CalcularProfesores(Profesores entidad)
        {

            return entidad;
        }
    }
}
