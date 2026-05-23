using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtMercado
{
    public Guid IntIdMercado { get; set; }

    public string? TxtMercado { get; set; }

    public decimal? DblValor { get; set; }
}
