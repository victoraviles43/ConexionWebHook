using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCuentaPromotor
{
    public int LngIdCuentaPromotor { get; set; }

    public int LngIdPromotor { get; set; }

    public bool? BolPrincipal { get; set; }

    public string? TxtFolio { get; set; }

    public string? TxtAlias { get; set; }

    public string? TxtBanco { get; set; }

    public string? TxtCuenta { get; set; }

    public string? TxtClabe { get; set; }

    public bool? BolActivo { get; set; }
}
