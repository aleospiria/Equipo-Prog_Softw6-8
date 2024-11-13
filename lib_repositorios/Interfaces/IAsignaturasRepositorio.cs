using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IAsignaturasRepositorio
    {
        void Configurar(string string_conexion);
        List<Asignaturas> Listar();
        List<Asignaturas> Buscar(Expression<Func<Asignaturas, bool>> condiciones);
        Asignaturas Guardar(Asignaturas entidad);
        Asignaturas Modificar(Asignaturas entidad);
        Asignaturas Borrar(Asignaturas entidad);
    }
}
