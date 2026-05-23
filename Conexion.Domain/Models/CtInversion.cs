using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtInversion
{
    public Guid IntIdInversion { get; set; }

    public string? TxtInversion { get; set; }

    public decimal? DblValor { get; set; }
}
