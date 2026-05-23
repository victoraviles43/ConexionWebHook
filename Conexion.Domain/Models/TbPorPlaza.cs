using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbPorPlaza
{
    public int LngIdPorPlazas { get; set; }

    public int? IntIdPlaza { get; set; }

    public decimal? DblPorcentajeCorp { get; set; }

    public decimal? DblPorcentajeCec { get; set; }

    public decimal? DblPorcentajePlaza { get; set; }

    public int? IntIdEmpresa { get; set; }
}
