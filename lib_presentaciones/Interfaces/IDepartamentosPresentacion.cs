using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IDepartamentosPresentacion
    {
        Task<List<Departamentos>> Listar();
        Task<List<Departamentos>> Buscar(Departamentos entidad, string tipo);
        Task<Departamentos> Guardar(Departamentos entidad);
        Task<Departamentos> Modificar(Departamentos entidad);
        Task<Departamentos> Borrar(Departamentos entidad);
    }
}