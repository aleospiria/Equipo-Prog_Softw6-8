using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Cursos
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public int FacultadId { get; set; }


        public Facultades Facultades { get; set; }

        
         public ICollection<Estudiantes>? Estudiantes { get;  set; }
         public ICollection<Asignaturas>? Asignaturas {get; set; }
         
        

        

       
        
    }
}