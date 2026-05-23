using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCuentasProv
{
    public int LngIdCuentasProv { get; set; }

    public int? LngIdProveedor { get; set; }

    public int? IntIdBanco { get; set; }

    public string? TxtClabe { get; set; }

    public string? TxtCuenta { get; set; }

    public bool? BolCancelada { get; set; }
}
