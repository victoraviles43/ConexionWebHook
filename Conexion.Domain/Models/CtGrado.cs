using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtGrado
{
    public Guid IntIdGrado { get; set; }

    public string? TxtGrado { get; set; }

    public decimal? DblValor { get; set; }
}
