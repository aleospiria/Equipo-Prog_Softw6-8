using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IEstudiantesPresentacion
    {
        Task<List<Estudiantes>> Listar();
        Task<List<Estudiantes>> Buscar(Estudiantes entidad, string tipo);
        Task<Estudiantes> Guardar(Estudiantes entidad);
        Task<Estudiantes> Modificar(Estudiantes entidad);
        Task<Estudiantes> Borrar(Estudiantes entidad);
    }
}