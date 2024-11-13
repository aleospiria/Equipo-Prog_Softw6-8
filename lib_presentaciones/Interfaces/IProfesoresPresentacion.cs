using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IProfesoresPresentacion
    {
        Task<List<Profesores>> Listar();
        Task<List<Profesores>> Buscar(Profesores entidad, string tipo);
        Task<Profesores> Guardar(Profesores entidad);
        Task<Profesores> Modificar(Profesores entidad);
        Task<Profesores> Borrar(Profesores entidad);
    }
}