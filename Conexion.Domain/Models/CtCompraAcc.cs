using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtCompraAcc
{
    public Guid IntIdCompraAcc { get; set; }

    public string? TxtCompraAcc { get; set; }

    public decimal? DblValor { get; set; }
}
