using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Proyecto
{
    public class Estudiantes
    {
        [Key] public int Id { get; set; } = 0;
        public string Carnet { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string Celular { get; set; } = "";
        public bool Estado { get; set; } = false;

        public ICollection<Materias>? MateriasEscogidas { get; set; }

    }

    public class Profesores
    {

        [Key]public string id { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string Cel { get; set; } = "";

        [NotMapped] public ICollection<Materias>? nombMaterias { get; set; }


    }

    public class Grupos
    {
        [Key] public string id { get; set; } = "";
        public Materias? Materia { get; set; } = null;
        public int Capacidad { get; set; } = 0;
        public Salones? NumSalon { get; set; } = null;
    }

    public class Materias
    {
        [Key] public string id { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Facultad { get; set; } = "";
    }

    public class Salones
    {
        [Key] public string id { get; set; } = "";
        public string TipoSalon { get; set; } = "";
    }
}