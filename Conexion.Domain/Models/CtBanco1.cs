using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtBanco1
{
    public int IntIdBanco { get; set; }

    public int? IntId { get; set; }

    public string? TxtBanco { get; set; }

    public int? IntIdPais { get; set; }

    public bool? BolActivo { get; set; }
}
