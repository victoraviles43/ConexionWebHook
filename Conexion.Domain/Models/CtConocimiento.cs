using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtConocimiento
{
    public Guid IntIdConocimiento { get; set; }

    public string? TxtConocimiento { get; set; }

    public decimal? DblValor { get; set; }
}
