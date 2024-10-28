using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Asignaturas
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Semestre { get; set; }
        public int DepartamentoId { get; set; }
        public int? ProfesorId {get; set; }

        public Departamentos Departamentos {get; set; }
        public Profesores? Profesores { get; set; }  
        public ICollection<Cursos>? Cursos { get; set; } 


        public void definirCronogramaEstudio()
        {
            // contenido del método
        }
    }
}
