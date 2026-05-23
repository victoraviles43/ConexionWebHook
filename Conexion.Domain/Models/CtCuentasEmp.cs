using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtCuentasEmp
{
    public int IntIdRegCuenta { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public string? NumCuenta { get; set; }

    public bool? BolActiva { get; set; }

    public int? IntIdBanco { get; set; }

    public string? TxtClabe { get; set; }
}
