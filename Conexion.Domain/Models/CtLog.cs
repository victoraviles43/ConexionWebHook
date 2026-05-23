using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtLog
{
    public Guid LngIdLog { get; set; }

    public string? TxtLog { get; set; }
}
