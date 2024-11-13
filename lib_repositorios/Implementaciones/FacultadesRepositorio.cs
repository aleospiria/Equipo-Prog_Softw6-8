using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class FacultadesRepositorio
    {
        private Conexion? conexion = null;

        public FacultadesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Facultades> Listar()
        {
            return conexion!.Listar<Facultades>();
        }

        public List<Facultades> Buscar(Expression<Func<Facultades, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Facultades Guardar(Facultades entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Facultades Modificar(Facultades entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Facultades Borrar(Facultades entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
