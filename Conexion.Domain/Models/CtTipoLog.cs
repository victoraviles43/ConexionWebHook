using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtTipoLog
{
    public int IntIdTipoLog { get; set; }

    public string? TxtTipo { get; set; }

    public bool? BolActivo { get; set; }
}
