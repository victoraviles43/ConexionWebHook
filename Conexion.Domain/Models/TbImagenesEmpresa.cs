using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbImagenesEmpresa
{
    public int LngIdImagen { get; set; }

    public int IntIdEmpresa { get; set; }

    public string ImagenUrl { get; set; } = null!;
}
