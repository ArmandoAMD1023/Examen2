using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Examen2.Models;

public partial class Autores
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Libros> obLibros { get; set; } = new List<Libros>();
}
