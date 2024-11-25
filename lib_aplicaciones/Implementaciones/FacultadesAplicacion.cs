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
    public class FacultadesAplicacion : IFacultadesAplicacion
    {
        private IFacultadesRepositorio? iRepositorio = null;
        public FacultadesAplicacion(IFacultadesRepositorio
        iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }
        public Facultades Borrar(Facultades entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }
        public Facultades Guardar(Facultades entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");
            entidad = CalcularFacultades(entidad);
            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }
        public List<Facultades> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Facultades> Buscar(Facultades entidad, string
        tipo)
        {
            Expression<Func<Facultades, bool>>? condiciones =
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
        public Facultades Modificar(Facultades entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = CalcularFacultades(entidad);
            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
        private Facultades CalcularFacultades(Facultades entidad)
        {

            return entidad;
        }
    }
}
