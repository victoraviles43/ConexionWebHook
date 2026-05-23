using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtFondo
{
    public Guid IntIdFondos { get; set; }

    public string? TxtFondos { get; set; }

    public decimal? DblValor { get; set; }
}
