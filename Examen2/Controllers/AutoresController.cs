using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Examen2.Models;

namespace Examen2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly LibreriaContext _dbContext;

        public AutoresController(LibreriaContext dbContext)
        {
            _dbContext = dbContext;
        }
        // CREAR NUEVO AUTOR
        [HttpPost]
        [Route("CrearAutor")]
        public IActionResult CrearAutor([FromBody] Autores nuevoAutor)
        {
            try
            {
                _dbContext.Autores.Add(nuevoAutor);
                _dbContext.SaveChanges();

                return StatusCode(201, new { mensaje = "Autor creado exitosamente", Response = nuevoAutor });
            }
            catch (Exception ex)
            {
                string innerExceptionMessage = ex.InnerException != null ? ex.InnerException.Message : "No hay información adicional sobre la excepción interna.";

                return StatusCode(500, new { mensaje = "Error al crear el autor", Error = ex.Message, InnerError = innerExceptionMessage });
            }
        }

        //ObtenerTodosLosAutores
        [HttpGet]
        [Route("ObtenerTodosLosAutores")]
        public IActionResult ObtenerTodosLosAutores()
        {
            try
            {
                var autores = _dbContext.Autores.ToList();

                return Ok(new { mensaje = "Autores obtenidos exitosamente", Response = autores });
            }
            catch (Exception ex)
            {
                string innerExceptionMessage = ex.InnerException != null ? ex.InnerException.Message : "No hay información adicional sobre la excepción interna.";

                return StatusCode(500, new { mensaje = "Error al obtener los autores", Error = ex.Message, InnerError = innerExceptionMessage });
            }
        }
    }

}
