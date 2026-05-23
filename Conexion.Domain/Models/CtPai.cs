using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtPai
{
    public Guid IntIdPais { get; set; }

    public string? TxtPais { get; set; }

    public decimal? ValPunto { get; set; }
}
