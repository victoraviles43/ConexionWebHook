using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtEstrategium
{
    public Guid IntIdEstrategia { get; set; }

    public string? TxtEstrategia { get; set; }

    public decimal? DblValor { get; set; }
}
