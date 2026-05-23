using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpeOpcione
{
    public Guid LngIdOpeOpciones { get; set; }

    public Guid? LngIdOpeGeneral { get; set; }

    public int? IntIdPayout { get; set; }

    public decimal? DblStrike { get; set; }

    public decimal? DblEquivQty { get; set; }

    public DateTime? FecExpiracion { get; set; }

    public DateTime? Delivery { get; set; }

    public decimal? DblMoneyness { get; set; }

    public decimal? DblPrima { get; set; }

    public decimal? PorPrima { get; set; }

    public decimal? NumFlatPremium { get; set; }

    public DateTime? FecPagoPrima { get; set; }

    public decimal? NumSpot { get; set; }

    public decimal? PorVolatility { get; set; }

    public DateTime? FecStartDate { get; set; }

    public int? IntIdEntrega { get; set; }

    public decimal? PorDiscountRate { get; set; }

    public decimal? PorDivYidRate { get; set; }

    public decimal? PorExchange { get; set; }

    public decimal? NumVega { get; set; }

    public decimal? NumCalibratedGamma { get; set; }

    public decimal? NumTheta { get; set; }

    public string? TxtClave { get; set; }

    public string? TxtConsecutivo { get; set; }

    public Guid? IntIdPayoutCurrency { get; set; }
}
