using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbQrImagen
{
    public int IntIdQrImagen { get; set; }

    public int? IntIdActivos { get; set; }

    public byte[]? ArQrImagen { get; set; }
}
