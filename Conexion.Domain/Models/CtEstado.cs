using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtEstado
{
    public Guid IntIdEstado { get; set; }

    public string? TxtEstado { get; set; }

    public decimal? ValPunto { get; set; }
}
