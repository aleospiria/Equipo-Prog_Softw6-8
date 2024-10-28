using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Estudiantes
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad {  get; set; }
        public string Direccion { get; set; }
        public int Numero_de_Contacto { get; set; }

        public ICollection<Cursos>? Cursos { get; set; }

        public void Matricular()
        {
            // contenido del método
        }

        public void TomarCurso()
        {
            // contenido del metodo
        }
    }
}
