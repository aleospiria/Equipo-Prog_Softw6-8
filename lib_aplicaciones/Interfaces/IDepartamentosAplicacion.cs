using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IDepartamentosAplicacion
    {
        void Configurar(string string_conexion);
        List<Departamentos> Buscar(Departamentos entidad, string tipo);
        List<Departamentos> Listar();
        Departamentos Guardar(Departamentos entidad);
        Departamentos Modificar(Departamentos entidad);
        Departamentos Borrar(Departamentos entidad);
    }
}