using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtTipoGastoUx
{
    public int IntIdTipoGastoUx { get; set; }

    public string? TxtTipoGastoUx { get; set; }

    public string? TxtCuentaUx { get; set; }

    public bool? BolBajaUx { get; set; }
}
