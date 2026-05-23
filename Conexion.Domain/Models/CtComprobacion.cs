using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtComprobacion
{
    public int IntIdComprobacion { get; set; }

    public string? TxtComprobacion { get; set; }

    public string? TxtCodigo { get; set; }
}
