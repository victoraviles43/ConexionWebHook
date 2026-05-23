using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtTipoGastoM
{
    public int IntIdTipoGastoM { get; set; }

    public string? TxtTipoGastoM { get; set; }

    public string? TxtCuenta { get; set; }

    public bool? BolBaja { get; set; }
}
