using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpeGeneral
{
    public Guid LngIdGeneral { get; set; }

    public Guid? IntIdTipoOperacion { get; set; }

    public Guid? IntIdInstrumento { get; set; }

    public Guid? IntIdMonedaSub { get; set; }

    public int? IntValCantidad { get; set; }

    public decimal? DecPrecioPactado { get; set; }

    public decimal? DecMarketPrice { get; set; }

    public Guid? IntLiquidacionPactada { get; set; }

    public DateOnly? FecLiquidacion { get; set; }

    public DateOnly? FecPanyment { get; set; }

    public decimal? DecMontoPactado { get; set; }

    public string? TxtFxSpot { get; set; }

    public string? TxtObservaciones { get; set; }

    public string? TxtCotizacion1 { get; set; }

    public string? TxtCotizacion2 { get; set; }

    public string? TxtCotizacion3 { get; set; }

    public string? TxtBlockTrade { get; set; }

    public string? TxtAllocationMatrix { get; set; }

    public Guid? LngIdCliente { get; set; }

    public Guid? LngIdCuentaBancaria { get; set; }

    public Guid? IntIdContraparte { get; set; }

    public Guid? IntIdMedioConcer { get; set; }

    public TimeOnly? HoraOperacion { get; set; }

    public Guid? IntIdCompraVenta { get; set; }

    public DateTime? FecIni { get; set; }

    public Guid? IntIdEstatus { get; set; }

    public string? TxtRegistro { get; set; }

    public string? TxtTipoValor { get; set; }

    public string? TxtSerie { get; set; }

    public string? TxtEmisora { get; set; }

    public string? TxtMonedaNom { get; set; }

    public string? TxtCupon { get; set; }

    public string? TxtNombreCom { get; set; }

    public DateOnly? FecFechaVec { get; set; }

    public bool? BolCongelar { get; set; }
}
