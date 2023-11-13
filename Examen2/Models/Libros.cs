using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen2.Models
{
    public partial class Libros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Titulo { get; set; } = null!;

        public int? Capitulos { get; set; }

        public int? Paginas { get; set; }

        public decimal? Precio { get; set; }

        public int? AutorId { get; set; }

        public virtual Autores? Autor { get; set; }
    }
}

