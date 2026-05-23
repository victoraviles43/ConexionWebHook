using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCuentaProveedore
{
    public int LngIdCuentaProveedores { get; set; }

    public string? TxtCuenta { get; set; }

    public int? LngIdProveedor { get; set; }

    public int? IntIdBanco { get; set; }

    public string? TxtClabe { get; set; }
}
