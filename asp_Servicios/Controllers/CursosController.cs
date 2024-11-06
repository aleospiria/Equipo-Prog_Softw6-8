using lib_aplicaciones.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace asp_Servicios.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class CursosController: ControllerBase
    {
        private ICursosAplicacion? iAplicacion=null;
        private TokenController? tokenController=null;

        //Constructor inyeccion dependencias
        public CursosController(ICursosAplicacion? iAplicacion, TokenController? tokenController)
        {
            this.iAplicacion = iAplicacion ?? throw new ArgumentNullException(nameof(iAplicacion));
            this.tokenController = tokenController;

        }
    }
}
