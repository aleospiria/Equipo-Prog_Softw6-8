using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Estudiantes
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad {  get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre) ||
                Edad <= 0 == null)
                return false;
            return true;
        }
        public void matricular()
        {
            // contenido del método
        }

        public void tomarCurso()
        {
            // contenido del metodo
        }
    }
}
