using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Examen2.Models;
using Examen2.Models.Examen2.Models;
using System.Data;

namespace Examen2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {

        public readonly LibreriaContext dbcontext;

        public LibrosController(LibreriaContext context)
        {
            dbcontext = context;
        }

    //CREAR N LIBRO
        [HttpPost]
        [Route("CrearLibro")]
        public IActionResult Crear([FromBody]Libros objeto)
        {
            try
            {
                dbcontext.Libros.Add(objeto);
                dbcontext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new {mensaje = "ok"});
            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }

        }


        //Libro por Id
        [HttpGet]
        [Route("LibroPorId{Id:int}")]

        public IActionResult obtener(int Id)
        {
            Libros oLibros
                = dbcontext.Libros.Find(Id);

            if (oLibros==null)
                return BadRequest("No esta ese id,Libro no encontrado");
            {

            }
            try
            {
                oLibros = dbcontext.Libros.Include(d => d.AutorId).Where(e => e.Id == Id).FirstOrDefault();
            

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", Response = oLibros });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", Response = oLibros });
            }

        }
        //Todos los libros
        [HttpGet]
        [Route ("TodosLosLibros")]

        public IActionResult Lista()
        {
            List<Libros> lista
                = new List<Libros>();
            try
            {
                lista = dbcontext.Libros.Include(d => d.Autor).ToList();

                return Ok(lista);
            }
            catch(Exception ex) 
            {
                return Ok(lista);
            }

        }

    }
}
