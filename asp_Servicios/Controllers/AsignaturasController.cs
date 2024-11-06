using asp_Servicios.Nucleo;
using lib_aplicaciones.Implementaciones;
using lib_aplicaciones.Interfaces;
using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_utilidades;
using Microsoft.AspNetCore.Mvc;

namespace asp_Servicios.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AsignaturasController : ControllerBase
    {

        private IAsignaturasAplicacion? iAplicacion = null;
        private TokenController? tokenController = null;

        //Constructor inyeccion dependencias
        public AsignaturasController(IAsignaturasAplicacion? iAplicacion, TokenController? tokenController)
        {
            this.iAplicacion = iAplicacion ?? throw new ArgumentNullException(nameof(iAplicacion));
            this.tokenController = tokenController;



        }

        private Dictionary<string, object> ObtenerDatos()
        {
            var respuesta = new Dictionary<string, object>();
            try
            {
                var datos = new StreamReader(Request.Body).ReadToEnd().ToString();
                if (string.IsNullOrEmpty(datos))
                    datos = "{}";
                return JsonConversor.ConvertirAObjeto(datos);
            }
            catch (Exception ex)
            {
                respuesta["Error"] = ex.Message.ToString();
                return respuesta;
            }
        }
        [HttpPost]
        public string Listar()
        {
            var respuesta = new Dictionary<string, object>();
            try
            {
                var datos = ObtenerDatos();
                if (!tokenController!.Validate(datos))
                {
                    respuesta["Error"] = "lbNoAutenticacion";
                    return JsonConversor.ConvertirAString(respuesta);
                }
                this.iAplicacion!.Configurar(Configuracion.ObtenerValor("ConectionString"));
                respuesta["Entidades"] = this.iAplicacion!.Listar();
                respuesta["Respuesta"] = "OK";
                respuesta["Fecha"] = DateTime.Now.ToString();
                return JsonConversor.ConvertirAString(respuesta);
            }
            catch (Exception ex)
            {
                respuesta["Error"] = ex.Message.ToString();
                return JsonConversor.ConvertirAString(respuesta);
            }
        }



        //Metodos Para manejar solicitudes GET

        //[HttpGet]
        //public ActionResult<IEnumerable<Asignaturas>> Get()
        //{
        //    try
        //    {
        //        var lista = this.iAplicacion.Listar();
        //        if (lista == null || !lista.Any())
        //        {
        //            return NoContent(); // Devuelve 204 si no hay elementos
        //        }

        //        return Ok(lista.ToArray()); // Devuelve 200 con la lista de asignaturas
        //    }
        //    catch (Exception ex)
        //    {
        //        // Manejo de excepciones
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }
        //}
        //GET por parametro

        [HttpGet("buscar")]
        public ActionResult<IEnumerable<Asignaturas>> Buscar([FromQuery] Asignaturas entidad, [FromQuery] string tipo)
        {
            try
            {
                var resultados = this.iAplicacion.Buscar(entidad, tipo);
                if (resultados == null || !resultados.Any())
                {
                    return NoContent(); // Devuelve 204 si no hay resultados
                }

                return Ok(resultados); // Devuelve 200 con los resultados encontrados
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //GET por ID
        [HttpGet("{id}")]
        public ActionResult<Asignaturas> GetById(int id)
        {
            try
            {
                var asignatura = this.iAplicacion.BuscarId(id);
                if (asignatura == null)
                {
                    return NotFound(); // Devuelve 404 si no se encuentra la asignatura
                }

                return Ok(asignatura); // Devuelve 200 con la asignatura encontrada
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //POST Guardar asignatura
        [HttpPost]
        public ActionResult<Asignaturas> Guardar([FromBody] Asignaturas entidad)
        {
            try
            {
                var asignatura = this.iAplicacion.Guardar(entidad);
                return CreatedAtAction(nameof(GetById), new { id = asignatura.Id }, asignatura); // Devuelve 201 con la URL del nuevo recurso
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //PUT update asignatura
        [HttpPut("{id}")]
        public ActionResult<Asignaturas> Modificar(int id, [FromBody] Asignaturas entidad)
        {
            try
            {
                if (id != entidad.Id)
                {
                    return BadRequest("El ID de la URL no coincide con el ID del cuerpo de la solicitud"); // Devuelve 400 si los IDs no coinciden
                }

                var asignatura = this.iAplicacion.Modificar(entidad);
                return Ok(asignatura); // Devuelve 200 con la asignatura modificada
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }


        }

        //Delete borrar asginatura
        [HttpDelete("{id}")]
        public ActionResult<Asignaturas> Borrar(int id)
        {
            try
            {
                var asignatura = this.iAplicacion.BuscarId(id);
                if (asignatura == null)
                {
                    return NotFound(); // Devuelve 404 si no se encuentra la asignatura
                }

                this.iAplicacion.Borrar(asignatura);
                return Ok(asignatura); // Devuelve 200 con la asignatura borrada
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }
}
