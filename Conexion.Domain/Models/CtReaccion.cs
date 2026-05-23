using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtReaccion
{
    public Guid IntIdReaccion { get; set; }

    public string? TxtReaccion { get; set; }

    public decimal? DblValor { get; set; }
}
