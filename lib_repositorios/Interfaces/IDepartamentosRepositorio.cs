using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IDepartamentosRepositorio
    {
        void Configurar(string string_conexion);
        List<Departamentos> Listar();
        List<Departamentos> Buscar(Expression<Func<Departamentos, bool>> condiciones);
        Departamentos Guardar(Departamentos entidad);
        Departamentos Modificar(Departamentos entidad);
        Departamentos Borrar(Departamentos entidad);
    }
}
