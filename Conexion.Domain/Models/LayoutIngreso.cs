using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class LayoutIngreso
{
    public DateTime? Fecha { get; set; }

    public string? UnidadDeNegocio { get; set; }

    public string? Concepto { get; set; }

    public string? Moneda { get; set; }

    public double? Importe { get; set; }

    public string? TipoDeIngreso { get; set; }

    public string? Cliente { get; set; }

    public string? Sucursal { get; set; }

    public string? Evento { get; set; }

    public string? Fiesta { get; set; }

    public string? Comentario { get; set; }
}
