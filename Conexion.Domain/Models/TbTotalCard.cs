using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbTotalCard
{
    public int LngIdTotalCard { get; set; }

    public string? TxtTotalCard { get; set; }

    public decimal? DblPorTotalCard { get; set; }

    public decimal? DblPorIva { get; set; }

    public int? IntIdUtilidad { get; set; }

    public bool? BolActivo { get; set; }
}
