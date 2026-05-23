using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtTipoGasto1
{
    public int IntIdTipoGastoS { get; set; }

    public string? TxtTipoGastoS { get; set; }

    public string? TxtCuenta { get; set; }

    public bool? BolBaja { get; set; }
}
