using System;

namespace ConsoleApp.AlquilerPeliculas
{
    public class Estudiantes
    {
        private string carnet = "" ;
        private int id = 0;
        private List<string> MateriasEscogidas = new List<string>();
        private string nombre = "";
        private string apellido = "";
        private string direccion = "";
        private string celular = "";
        private bool estado = false;

        public string carnet { get; set; };
        public int id { get; set; };
        public List<string> MateriasEscogidas { get; set; };
        public string nombre { get; set; };
        public string apellido { get; set; };
        public string dirección { get; set; };
        public string celular { get; set; };
        public bool estado { get; set; };


    }

    public class Profesores
    {
        private int id = 0;
        private List<string> NombMaterias = new List<string>();
        private string nombre = "";
        private string apellido = "";
        private string direccion = "";
        private string cel = "";

        public int id { get; set; };
        public List<string> NombMaterias { get; set; };
        public string nombre { get; set; };
        public string apellido { get; set; };
        public string direccion { get; set; };
        public string cel { get; set; };



    }

    public class Grupos
    {
        private int id = 0;
        private string nombreMateria = "";
        private int capacidad = 0;
        private string numSalon = "";

        public int id { get; set; };
        public string nombreMateria { get; set; };
        public int capacidad{ get; set; };
        public string numSalon { get; set; };

    }

    public class Materias
    {
        private int id = 0;
        private string nombre = "";
        private string facultad = "";
        //private Tipos? tipo = null;

        public int id { get; set; };
        public string nombre { get; set; };
        public string facultad { get; set; };
        //public Tipos? Tipo { get => this.tipo; set => this.tipo = value; }
    }

    public class Salones
    {
        private string id = "";
        private string tipoSalon = "";

        public string id { get; set; };
        public string tipoSalon { get; set; };


    }

    public class SalonesGrupos
    {
        private string id = "";
        private string numSalon = "";

       
    }
}