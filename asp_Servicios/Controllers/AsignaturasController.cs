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

        public AsignaturasController()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=EVILCC\\ACOSTA;database=db_notas;uid=dba;pwd=1234abcd;TrustServerCertificate=true;";
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
