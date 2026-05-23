using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCuentasPg
{
    public int IntIdCuentasPg { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? IntIdBancoPg { get; set; }

    public decimal? NumCuenta { get; set; }

    public decimal? NumClabe { get; set; }

    public int? IntIdPlaza { get; set; }

    public string? TxtAlias { get; set; }

    public bool? BolActiva { get; set; }

    public int? IntIdnegocio { get; set; }
}
