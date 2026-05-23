using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpeFuturosFx
{
    public Guid LngFuturosFx { get; set; }

    public Guid? LngIdGeneral { get; set; }

    public string? TxtMaturityPeriod { get; set; }

    public decimal? DecNominal { get; set; }

    public decimal? DecOtherNominal { get; set; }

    public Guid? IntIdMedioOpe { get; set; }

    public Guid? IntIdSocioOpe { get; set; }

    public Guid? IntIdSocioLiq { get; set; }

    public decimal? PorFee { get; set; }

    public decimal? DecTotalFees { get; set; }

    public string? TxtTotalFeesDet { get; set; }

    public string? TxtStrategy { get; set; }

    public string? TxtExtencion { get; set; }

    public Guid? IntIdContraparte { get; set; }

    public DateOnly? FecClave { get; set; }

    public string? TxtContraparteBt { get; set; }

    public string? TxtConsecutivo { get; set; }

    public Guid? IntIdTipoOrden { get; set; }

    public DateTime? FecIni { get; set; }

    public bool? BolCongelar { get; set; }

    public bool? IntIdMonedaInstr { get; set; }

    public string? TxtMedioOpe { get; set; }
}
