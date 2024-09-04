using System;

namespace ConsoleApp.ModeloUniversidad
{
    public class Estudiantes
    {
        private string carnet = "" ;
        private int id = 0;
        private List<string> materiasEscogidas = new List<string>();
        private string nombre = "";
        private string apellido = "";
        private string direccion = "";
        private string celular = "";
        private bool estado = false;

        public string Carnet { get => this.carnet; set => this.carnet = value; }
        public int Id { get => this.id; set => this.id= value; }
        public List<string> MateriasEscogidas { get => this.materiasEscogidas; set => this.materiasEscogidas= value; }
        public string Nombre { get => this.nombre; set => this.nombre= value; }
        public string Apellido { get => this.apellido; set => this.apellido= value; }
        public string Direccion { get => this.direccion; set => this.direccion= value; }
        public string Celular { get => this.celular; set => this.celular= value; }
        public bool Estado { get => this.estado; set => this.estado= value; }
    }

    public class Profesores
    {
        private int id = 0;
        private List<string> nombMaterias = new List<string>();
        private string nombre = "";
        private string apellido = "";
        private string direccion = "";
        private string cel = "";

        public string Id { get => this.id; set => this.id= value; }
        public List<string> NombMaterias { get => this.nombMaterias; set => this.nombMaterias= value; }
        public string Nombre { get => this.nombre; set => this.nombre= value; }
        public string Apellido { get => this.apellido; set => this.apellido= value; }
        public string Direccion { get => this.direccion; set => this.direccion= value; }
        public string Cel { get => this.cel; set => this.cel= value; }
    }

    public class Grupos
    {
        private int id = 0;
        private Materias? materia = null;
        private int capacidad = 0;
        private Salones? numSalon = null;

        public string Id { get => this.id; set => this.id = value; }
        public Materias? Materia { get => this.materia; set => this.materia= value; }
        public int Capacidad { get => this.capacidad; set => this.capacidad = value; }
        public Salones? NumSalon { get => this.numSalon; set => this.numSalon = value; }

    }

    public class Materias
    {
        private int id = 0;
        private string nombre = "";
        private string facultad = "";

        public int Id { get => this.id; set => this.id= value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Facultad { get => this.facultad; set => this.facultad = value; }
    }

    public class Salones
    {
        private string id = "";
        private string tipoSalon = "";

        public string Id { get => this.id; set => this.id= value; }
        public string TipoSalon { get => this.tipoSalon; set => this.tipoSalon = value; }


    }

    public class SalonesGrupos
    {
        private Grupos? id = null;
        private Salones? numSalon = null;

        public Grupos? Id { get => this.id; set => this.id= value; }
        public Salones? NumSalon { get => this.numSalon; set => this.numSalon = value; }
    }
}