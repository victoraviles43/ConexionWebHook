using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpeSpotFdw
{
    public Guid LngIdSpotFdw { get; set; }

    public Guid? LngIdGeneral { get; set; }

    public decimal? DecMoneda1 { get; set; }

    public decimal? DecMoneda2 { get; set; }

    public DateOnly? FecVence { get; set; }

    public string? TxtResultMaturity { get; set; }

    public decimal? DecPrecio { get; set; }

    public decimal? DecSwapPoints { get; set; }

    public string? TxtSpot { get; set; }

    public bool? BolEntregaDif { get; set; }

    public DateOnly? FecFixingDate { get; set; }

    public string? TxtMonedaLiq { get; set; }

    public string? TxtArchiving { get; set; }

    public string? TxtMedioOperacion { get; set; }

    public string? TxtStrategy { get; set; }

    public string? TxtClave { get; set; }

    public string? TxtExtension { get; set; }

    public string? TxtConsecutivo { get; set; }

    public DateTime? FecIni { get; set; }

    public bool? BolCongelar { get; set; }
}
