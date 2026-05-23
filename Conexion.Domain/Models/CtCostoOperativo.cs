using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtCostoOperativo
{
    public int LngIdCostoOperativo { get; set; }

    public string? TxtConcepto { get; set; }

    public decimal? DblCostoOperativo { get; set; }

    public bool? BolActivo { get; set; }
}
