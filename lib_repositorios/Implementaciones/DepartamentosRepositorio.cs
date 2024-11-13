using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class DepartamentosRepositorio : IDepartamentosRepositorio
    {
        private Conexion? conexion = null;

        public DepartamentosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Departamentos> Listar()
        {
            return conexion!.Listar<Departamentos>();
        }

        public List<Departamentos> Buscar(Expression<Func<Departamentos, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Departamentos Guardar(Departamentos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Departamentos Modificar(Departamentos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Departamentos Borrar(Departamentos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
