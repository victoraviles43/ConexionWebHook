using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtMotivo
{
    public int IntIdMotivo { get; set; }

    public string? TxtMotivo { get; set; }

    public bool? BolActivo { get; set; }
}
