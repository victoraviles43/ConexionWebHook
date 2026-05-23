using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ViewGridCxppro
{
    public int IdSolicitdCxp { get; set; }

    public string? Departamento { get; set; }

    public string? Plaza { get; set; }

    public string? Negocio { get; set; }

    public string? TipoPago { get; set; }

    public string? Moneda { get; set; }

    public decimal? Importe { get; set; }

    public DateTime? Dia { get; set; }

    public DateTime? ProxVencimiento { get; set; }

    public string? Status { get; set; }

    public string? Empresa { get; set; }
}
