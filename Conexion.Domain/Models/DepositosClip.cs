using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class DepositosClip
{
    public DateOnly? FechaDesembolso { get; set; }

    public string? IdReporteLiquidacion { get; set; }

    public int? MontoBruto { get; set; }

    public decimal? TarifaTotal { get; set; }

    public decimal? ImpuestoTotal { get; set; }

    public int? RetencionTotal { get; set; }

    public decimal? MontoNetoDesembolsado { get; set; }

    public int? TotalTransacciones { get; set; }
}
