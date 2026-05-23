using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtOperacion
{
    public int IntIdOperacion { get; set; }

    public string? TxtOperacion { get; set; }

    public int? IntIdOrden { get; set; }
}
