using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IEstudiantesRepositorio
    {
        void Configurar(string string_conexion);
        List<Estudiantes> Listar();
        List<Estudiantes> Buscar(Expression<Func<Estudiantes, bool>> condiciones);
        Estudiantes Guardar(Estudiantes entidad);
        Estudiantes Modificar(Estudiantes entidad);
        Estudiantes Borrar(Estudiantes entidad);
    }
}
