using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtGiro
{
    public Guid IntIdGiro { get; set; }

    public string? TxtGiro { get; set; }

    public decimal? ValPunto { get; set; }
}
