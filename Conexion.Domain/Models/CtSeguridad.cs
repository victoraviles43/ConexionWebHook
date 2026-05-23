using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtSeguridad
{
    public Guid IntIdSeguridad { get; set; }

    public string? TxtSeguridad { get; set; }

    public decimal? DblValor { get; set; }
}
