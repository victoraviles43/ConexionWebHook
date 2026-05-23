using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtNegocio
{
    public int IntIdNegocio { get; set; }

    public string? TxtNegocio { get; set; }

    public string? TxtNomCorto { get; set; }

    public bool? BolBaja { get; set; }
}
