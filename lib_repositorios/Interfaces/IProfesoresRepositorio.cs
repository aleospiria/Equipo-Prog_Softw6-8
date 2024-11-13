using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IProfesoresRepositorio
    {
        void Configurar(string string_conexion);
        List<Profesores> Listar();
        List<Profesores> Buscar(Expression<Func<Profesores, bool>> condiciones);
        Profesores Guardar(Profesores entidad);
        Profesores Modificar(Profesores entidad);
        Profesores Borrar(Profesores entidad);
    }
}
