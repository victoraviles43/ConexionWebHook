using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCuentasBancaria04
{
    public Guid LngIdCuentaBancaria { get; set; }

    public Guid? LngIdCliente { get; set; }

    public Guid? IntIdBanco { get; set; }

    public string? TxtSucursal { get; set; }

    public string? TxtCuenta { get; set; }

    public Guid? IntIdCuenta { get; set; }

    public string? TxtTitular { get; set; }

    public string TxtClabe { get; set; } = null!;

    public bool? BolCongelar { get; set; }
}
