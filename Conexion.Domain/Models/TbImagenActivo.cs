using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbImagenActivo
{
    public int IntIdImagen { get; set; }

    public int? IntIdActivos { get; set; }

    public byte[]? ArImagen { get; set; }
}
