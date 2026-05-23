using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpeBono
{
    public Guid LngIdBonos { get; set; }

    public Guid? LngIdGeneral { get; set; }

    public DateOnly? FecOperacion { get; set; }

    public Guid? IntIdMonedaInstr { get; set; }

    public decimal? DecValMonedaInstr { get; set; }

    public decimal? DecNominal { get; set; }

    public decimal? IntValCuponDev { get; set; }

    public decimal? DecSettl { get; set; }

    public decimal? DecPrecioSucioPacto { get; set; }

    public decimal? DecPrecioSucioLiq { get; set; }

    public decimal? DecTasaPactada { get; set; }

    public decimal? DecMontoLiq { get; set; }

    public string? TxtCurrency { get; set; }

    public string? TxtCapFactor { get; set; }

    public string? TxtEvalyield { get; set; }

    public string? TxtCupon { get; set; }

    public DateOnly? FecVence { get; set; }

    public string? TxtIncode { get; set; }

    public Guid? IntIdEmisor { get; set; }

    public DateOnly? FecTradingDate { get; set; }

    public Guid? IntIdBancoTrabajo { get; set; }

    public DateTime? FecIni { get; set; }

    public bool? BolCongelar { get; set; }
}
