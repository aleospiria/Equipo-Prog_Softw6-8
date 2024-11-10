using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IUniversidadesPresentacion
    {
        Task<List<Universidades>> Listar();
        Task<List<Universidades>> Buscar(Universidades entidad, string tipo);
        Task<Universidades> Guardar(Universidades entidad);
        Task<Universidades> Modificar(Universidades entidad);
        Task<Universidades> Borrar(Universidades entidad);
    }
}