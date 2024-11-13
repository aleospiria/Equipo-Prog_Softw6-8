using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface ICursosAplicacion
    {
        void Configurar(string string_conexion);
        List<Cursos> Buscar(Cursos entidad, string tipo);
        List<Cursos> Listar();
        Cursos Guardar(Cursos entidad);
        Cursos Modificar(Cursos entidad);
        Cursos Borrar(Cursos entidad);
    }
}