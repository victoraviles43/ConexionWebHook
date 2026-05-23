using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtFeServicio
{
    public int IntIdServicio { get; set; }

    public string? TxtServicio { get; set; }

    public int? IntIdUnidadNeg { get; set; }

    public string? TxtNomCorto { get; set; }
}
