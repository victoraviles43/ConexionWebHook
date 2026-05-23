using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtInstrumento
{
    public Guid IntIdInstrumentos { get; set; }

    public string? TxtTipoValor { get; set; }

    public string? TxtEmisora { get; set; }

    public string? TxtSerie { get; set; }

    public string? TxtMonedaNom { get; set; }

    public string? TxtCupon { get; set; }

    public string? TxtNombreCom { get; set; }

    public DateOnly? FecFechaVec { get; set; }

    public decimal? DblPrecioLimpio { get; set; }
}
