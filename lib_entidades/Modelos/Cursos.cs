using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Cursos
    {
        [Key] public int Id { get; set; }
        public string NombreCurso { get; set; }
        public int Creditos { get; set; }
        public string? Profesor { get; set; }
        public string Estudiante { get; set; }
        public string Departamento { get; set; }

        

        [NotMapped] public Departamentos? _Departamento { get; set; }
        [NotMapped] public Profesores? _Profesor { get; set; }
        [NotMapped] public Estudiantes? _Estudiante { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombreCurso) ||
                Creditos<=0 == null)
                return false;
            return true;
        }
        public void asignarProfesor()
        {
            // contenido del método
        }

        public void matricularEstudiante()
        {
            // contenido del metodo
        }
        
    }
}