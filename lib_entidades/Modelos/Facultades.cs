using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Facultades
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        [NotMapped] public Departamentos? _Departamento { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre) == null)
                return false;
            return true;
        }
        public void gestionarDepartamento()
        {
            // contenido del método
        }
    }
}
