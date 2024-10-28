using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Facultades
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Descripcion { get; set; }
        public string? Decano { get; set; }
        public ICollection<Departamentos>? _Departamento { get; set; }

        public void gestionarDepartamento()
        {
            // contenido del método
        }
    }
}
