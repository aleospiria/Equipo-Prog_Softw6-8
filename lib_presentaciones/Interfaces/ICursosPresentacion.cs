using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface ICursosPresentacion
    {
        Task<List<Cursos>> Listar();
        Task<List<Cursos>> Buscar(Cursos entidad, string tipo);
        Task<Cursos> Guardar(Cursos entidad);
        Task<Cursos> Modificar(Cursos entidad);
        Task<Cursos> Borrar(Cursos entidad);
    }
}