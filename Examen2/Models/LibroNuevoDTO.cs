using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Examen2.Models
{
    namespace Examen2.Models
    {
        public class LibroNuevoDTO
        {
            public string Titulo { get; set; }
            public int Capitulos { get; set; }
            public int Paginas { get; set; }
            public decimal Precio { get; set; }
            public int IdAutor { get; set; }  // Cambiado a int para reflejar el tipo de la propiedad Id en Autores
        }
    }

}




