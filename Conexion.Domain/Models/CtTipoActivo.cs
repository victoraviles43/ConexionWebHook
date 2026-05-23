using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtTipoActivo
{
    public int IntIdTipoActivo { get; set; }

    public string? TxtTipoActivo { get; set; }

    public string? TxtCodigo { get; set; }

    public decimal? DblPorDep { get; set; }

    public decimal? DblPorDepMes { get; set; }
}
