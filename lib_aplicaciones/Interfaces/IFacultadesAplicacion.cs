using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IFacultadesAplicacion
    {
        void Configurar(string string_conexion);
        List<Facultades> Buscar(Facultades entidad, string tipo);
        List<Facultades> Listar();
        Facultades Guardar(Facultades entidad);
        Facultades Modificar(Facultades entidad);
        Facultades Borrar(Facultades entidad);
    }
}