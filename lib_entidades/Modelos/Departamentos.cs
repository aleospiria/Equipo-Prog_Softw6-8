using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Departamentos
    {
        [Key] public int Id { get; set; }
        public string NombreDepartamento { get; set; }

        [NotMapped] public Facultades? Facultad { get; set; }
        [NotMapped] public Cursos? Curso { get; set; }

        public void administrarAsignaturas()
        {
            // contenido del método
        }
    }
}
