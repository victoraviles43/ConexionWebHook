using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtHolding
{
    public int IntIdHolding { get; set; }

    public string? TxtDescripcion { get; set; }

    public int? IntIdFHoldingTipo { get; set; }

    public int? IntIdFHoldingZona { get; set; }

    public bool? BolActivo { get; set; }
}
