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

        public int DepartamentosId { get; set; }
        public Departamentos Departamentos {get; set; }
        public int ProfesoresId { get; set; }
        public Profesores? Profesores { get; set; }  
        public ICollection<Cursos>? Cursos { get; set; }


        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre) ||
                DepartamentosId <= 0 ||
                ProfesoresId <= 0)
                return false;
            return true;
        }
    }
}
