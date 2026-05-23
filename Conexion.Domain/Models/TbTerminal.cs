using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbTerminal
{
    public int LngIdTerminal { get; set; }

    public string? TxtTerminal { get; set; }

    public decimal? DblPorTerminal { get; set; }

    public decimal? DblPorIva { get; set; }

    public int? IntOrden { get; set; }

    public bool? BolActivo { get; set; }
}
