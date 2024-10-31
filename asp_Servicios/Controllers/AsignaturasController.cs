using lib_aplicaciones.Implementaciones;
using lib_aplicaciones.Interfaces;
using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using Microsoft.AspNetCore.Mvc;

namespace asp_Servicios.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AsignaturasController: ControllerBase
    {

        private IAsignaturasAplicacion? IAplicacion = null;
        private TokenController? tokenController = null;

        public AsignaturasController()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "Server=salak403-39;Database=bd_univer;Integrated Security=True;";
            IAplicacion = new AsignaturasAplicacion(new AsignaturasRepositorio(conexion));



        }

        [HttpGet]
        public IEnumerable<Asignaturas> Get()
        {
            var lista = IAplicacion!.Listar();
            return lista.ToArray();
        }

    }
}
