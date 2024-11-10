using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Universidades
    {
        [Key] public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Cant_est { get; set; }
        public int? Cant_profe { get; set; }
        public int? Cant_carreras { get; set; }
        public string? Telefono { get; set; }
        public bool Activa { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre) ||
                string.IsNullOrEmpty(Direccion) ||
                string.IsNullOrEmpty(Telefono) ||
                Fecha == null)
                return false;
            return true;
        }
    }
}
