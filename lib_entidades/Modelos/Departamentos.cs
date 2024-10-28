using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Departamentos
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descipcion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int FacultadId { get; set; }

        public Facultades Facultades { get; set; }
        public ICollection<Asignaturas>? Asignaturas { get; set; }
        public ICollection<Profesores>? Profesores { get; set; } 

        public void AdministrarAsignaturas()
        {
            // contenido del método
        }
    }
}
