using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtPosicion
{
    public Guid IntIdPosicion { get; set; }

    public string? TxtPosicion { get; set; }

    public decimal? DblValor { get; set; }
}
