using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Profesores
    {
        [Key] public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Contacto { get; set; }
        public DateTime FechaContratacion { get; set; }
        public double Salario { get; set; }
        public int DepartamentoId {  get; set; }
        
        public Departamentos? Departamentos { get; set; }
        public ICollection<Asignaturas>? Asignaturas { get; set; }
        

        public void asignarCurso()
        {
            //Contenido del metodo
        }

        public void evaluarEstudiante()
        {
            //Contenido del metodo
        }

    }
}