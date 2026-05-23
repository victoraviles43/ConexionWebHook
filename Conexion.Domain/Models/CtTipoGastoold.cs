using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtTipoGastoold
{
    public int IntIdTipoGasto { get; set; }

    public string? TxtTipoGasto { get; set; }

    public string? TxtCuenta { get; set; }

    public bool? BolBaja { get; set; }
}
