using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Asignaturas
    {
        [Key] public int Id { get; set; }
        public string NombreAsignatura { get; set; }
        public string Duracion { get; set; }
        [NotMapped] public Cursos? _Curso { get; set; }
        public void definirCronogramaEstudio()
        {
            // contenido del método
        }
    }
}
