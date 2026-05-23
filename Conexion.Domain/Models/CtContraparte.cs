using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtContraparte
{
    public Guid IntIdContraparte { get; set; }

    public string? TxtContraparte { get; set; }

    public decimal? DblComision { get; set; }
}
