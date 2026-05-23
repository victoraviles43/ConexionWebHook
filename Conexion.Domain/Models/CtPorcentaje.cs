using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtPorcentaje
{
    public Guid IntIdPorcentaje { get; set; }

    public string? TxtPorcentaje { get; set; }

    public decimal? DblValor { get; set; }
}
