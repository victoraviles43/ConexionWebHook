using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCuenRegi
{
    public int LngIdCuenRegi { get; set; }

    public int? IntIdCuentasPg { get; set; }

    public int? IntIdRegion { get; set; }

    public DateOnly? FecDia { get; set; }

    public bool? BolActivo { get; set; }
}
