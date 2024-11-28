using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Profesores
    {
        [Key] public int Id { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public int Contacto { get; set; }
        public DateTime FechaContratacion { get; set; }
        public double Salario { get; set; }
        
        public int DepartamentosId { get; set; }
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

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombres))
                return false;
            return true;
        }

    }
}