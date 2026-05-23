using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtIntrumentosMig
{
    public string? Tipovalor { get; set; }

    public string? Emisora { get; set; }

    public string? Serie { get; set; }

    public string? Monedaemision { get; set; }

    public double? Cuponactual { get; set; }

    public string? Nombrecompleto { get; set; }

    public DateOnly? Fechavcto { get; set; }

    public decimal? Preciolimpio { get; set; }
}
