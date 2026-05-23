using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeRetoFina
{
    public int LngIdRetoFina { get; set; }

    public int? LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public decimal? DblImporteEstimado { get; set; }

    public int? IntIdPeriodicidad { get; set; }

    public string? TxtNotas { get; set; }
}
