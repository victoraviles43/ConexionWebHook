using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtEjecutivoOp
{
    public int IntIdEjecutivoOp { get; set; }

    public string? TxtEjecutivoOp { get; set; }

    public string? TxtRegEje { get; set; }

    public bool? BolActivo { get; set; }

    public int? IntIdusuario { get; set; }
}
