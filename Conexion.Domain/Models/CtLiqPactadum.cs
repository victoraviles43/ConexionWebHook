using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtLiqPactadum
{
    public Guid IntLiquidacionPactada { get; set; }

    public string? TxtLiquidacionPactada { get; set; }
}
