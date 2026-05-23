using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtModulo
{
    public int IntIdModulo { get; set; }

    public string? TxtModulo { get; set; }

    public bool? BolActivo { get; set; }
}
