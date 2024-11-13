using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IAsignaturasAplicacion
    {
        void Configurar(string string_conexion);
        List<Asignaturas> Buscar(Asignaturas entidad, string tipo);
        List<Asignaturas> Listar();
        Asignaturas Guardar(Asignaturas entidad);
        Asignaturas Modificar(Asignaturas entidad);
        Asignaturas Borrar(Asignaturas entidad);
    }
}