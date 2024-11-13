using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IAsignaturasPresentacion
    {
        Task<List<Asignaturas>> Listar();
        Task<List<Asignaturas>> Buscar(Asignaturas entidad, string tipo);
        Task<Asignaturas> Guardar(Asignaturas entidad);
        Task<Asignaturas> Modificar(Asignaturas entidad);
        Task<Asignaturas> Borrar(Asignaturas entidad);
    }
}