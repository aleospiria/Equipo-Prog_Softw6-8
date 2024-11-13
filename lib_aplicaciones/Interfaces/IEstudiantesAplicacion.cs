using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IEstudiantesAplicacion
    {
        void Configurar(string string_conexion);
        List<Estudiantes> Buscar(Estudiantes entidad, string tipo);
        List<Estudiantes> Listar();
        Estudiantes Guardar(Estudiantes entidad);
        Estudiantes Modificar(Estudiantes entidad);
        Estudiantes Borrar(Estudiantes entidad);
    }
}