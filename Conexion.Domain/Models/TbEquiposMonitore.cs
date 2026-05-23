using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEquiposMonitore
{
    public int LngIdEquipoMonitor { get; set; }

    public int? IntIdEstatusAsignacion { get; set; }

    public int? IntIdOficina { get; set; }

    public int? IntIdNegocio { get; set; }

    public string? TxtMarcaMonitor { get; set; }

    public string? TxtModeloMonitor { get; set; }

    public string? TxtSerieMonitor { get; set; }

    public DateTime? FecInicioContrato { get; set; }

    public DateTime? FecFinContrato { get; set; }

    public string? TxtContrato { get; set; }

    public decimal? DblCostoAnualMonitor { get; set; }

    public decimal? DblCostoMensualMonitor { get; set; }

    public string? TxtObservaciones { get; set; }

    public DateTime? FecInicio { get; set; }
}
