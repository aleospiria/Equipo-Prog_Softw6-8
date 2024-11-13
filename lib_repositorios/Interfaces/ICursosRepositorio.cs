using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface ICursosRepositorio
    {
        void Configurar(string string_conexion);
        List<Cursos> Listar();
        List<Cursos> Buscar(Expression<Func<Cursos, bool>> condiciones);
        Cursos Guardar(Cursos entidad);
        Cursos Modificar(Cursos entidad);
        Cursos Borrar(Cursos entidad);
    }
}
