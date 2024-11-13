using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IFacultadesPresentacion
    {
        Task<List<Facultades>> Listar();
        Task<List<Facultades>> Buscar(Facultades entidad, string tipo);
        Task<Facultades> Guardar(Facultades entidad);
        Task<Facultades> Modificar(Facultades entidad);
        Task<Facultades> Borrar(Facultades entidad);
    }
}