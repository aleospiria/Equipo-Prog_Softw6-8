using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_presentacion.Pages.Ventanas.Biblioteca
{
    public class BibliotecaModel : PageModel
    {
        public void OnGet()
        {
            //ViewData["Mensaje"] = "Pruebas de datos";

           /* Lista.Add(new Libros()
            {
                Codigo = "SHASJKF21",
                Nombre = "Programacion PHP",
                Descripcion = "Basico de php",
            });
            Lista.Add(new Libros()
            {
                Codigo = "876GHJGJ",
                Nombre = "Programacion para dummies",
                Descripcion = "Aprenda a programar en Node JS",
            });*/
        }

        [BindProperty] public Libros Actual { get; set; } = new Libros();
        [BindProperty] public List<Libros> Lista { get; set; } = new List<Libros>();

        public void OnPostBtGuardar()
        {
            Lista.Add(Actual);
        }
    }

    public class Libros
    {
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int? Cant_est { get; set; }
        public int? Cant_profes { get; set; }
        public int? Cant_carreras { get; set; }
        public string? Descripcion { get; set; }
    }
}