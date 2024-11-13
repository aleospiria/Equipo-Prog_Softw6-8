﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Profesores
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Departamento {  get; set; }
        public double Salario { get; set; }
        [NotMapped] public Departamentos? _Departamento { get; set; }

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