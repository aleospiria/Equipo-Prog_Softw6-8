using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IProfesoresAplicacion
    {
        void Configurar(string string_conexion);
        List<Profesores> Buscar(Profesores entidad, string tipo);
        List<Profesores> Listar();
        Profesores Guardar(Profesores entidad);
        Profesores Modificar(Profesores entidad);
        Profesores Borrar(Profesores entidad);
    }
}