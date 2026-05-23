using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtTipoGastoZ
{
    public int IntIdTipoGastoZ { get; set; }

    public string? TxtTipoGastoZ { get; set; }

    public string? TxtCuenta { get; set; }

    public bool? BolBaja { get; set; }
}
