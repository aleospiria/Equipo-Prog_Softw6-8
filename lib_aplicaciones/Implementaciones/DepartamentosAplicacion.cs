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
    public class DepartamentosAplicacion : IDepartamentosAplicacion
    {
        private IDepartamentosRepositorio? iRepositorio = null;
        public DepartamentosAplicacion(IDepartamentosRepositorio
        iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }
        public Departamentos Borrar(Departamentos entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }
        public Departamentos Guardar(Departamentos entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");
            entidad = CalcularDepartamentos(entidad);
            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }
        public List<Departamentos> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Departamentos> Buscar(Departamentos entidad, string
        tipo)
        {
            Expression<Func<Departamentos, bool>>? condiciones =
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
        public Departamentos Modificar(Departamentos entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");
            entidad = CalcularDepartamentos(entidad);
            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
        private Departamentos CalcularDepartamentos(Departamentos entidad)
        {

            return entidad;
        }
    }
}
