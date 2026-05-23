using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtHoldingTipo
{
    public int IntIdHoldingTipo { get; set; }

    public string? TxtTipo { get; set; }

    public bool? BolActivo { get; set; }
}
