using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEquiposMovile
{
    public int LngIdEquipoMovil { get; set; }

    public int? IntIdEstatusAsignacion { get; set; }

    public string? TxtImei { get; set; }

    public string? TxtMarcaMovil { get; set; }

    public string? TxtModeloMovil { get; set; }

    public int? IntIdOficina { get; set; }

    public int? IntIdNegocio { get; set; }

    public decimal? DblCostoAnualMovil { get; set; }

    public decimal? DblCostoMensualMovil { get; set; }

    public string? TxtObservaciones { get; set; }

    public DateTime? FecInicio { get; set; }
}
