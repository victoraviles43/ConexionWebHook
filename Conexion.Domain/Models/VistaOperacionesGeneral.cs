using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class VistaOperacionesGeneral
{
    public Guid LngIdGeneral { get; set; }

    public string? TipoDeOperacion { get; set; }

    public int? Cantidad { get; set; }

    public decimal? PrecioPactado { get; set; }

    public string? LiquidacionPactada { get; set; }

    public DateOnly? FechaLiquidacion { get; set; }

    public decimal? MontoPactado { get; set; }

    public string? Observaciones { get; set; }

    public string? Cotizacion1 { get; set; }

    public string? Cotizacion2 { get; set; }

    public string? Cotizacion3 { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? Empresa { get; set; }

    public string? Cuenta { get; set; }

    public string? Clabe { get; set; }

    public string? Titular { get; set; }

    public string? Contraparte { get; set; }

    public string? MedioDeConcertacion { get; set; }

    public string? Tipo { get; set; }

    public string? Serie { get; set; }

    public string? Emisora { get; set; }

    public string? MondedaEmision { get; set; }

    public string? Cupon { get; set; }

    public string? NombreCompleto { get; set; }

    public TimeOnly? HoraDeOperacion { get; set; }

    public decimal? ComisionAcciones { get; set; }

    public decimal? ImporteComisionAcciones { get; set; }

    public decimal? ImporteIvaAcciones { get; set; }

    public decimal? ImporteNetoAcciones { get; set; }

    public string? MercadoPrimarioAcciones { get; set; }

    public decimal? ValorMonedaInstrumentoBonos { get; set; }

    public decimal? NominalBonos { get; set; }

    public decimal? CuponDevengadoBonos { get; set; }

    public decimal? SettlAccuredAmountBonos { get; set; }

    public decimal? ComisionEtfs { get; set; }

    public decimal? ImporteComisionEtfs { get; set; }

    public int? SecFeeEtfs { get; set; }

    public decimal? ImporteSecFeeEtfs { get; set; }

    public decimal? ImporteIvaEtfs { get; set; }

    public string? MercadoPrimarioEtfs { get; set; }

    public decimal? ImporteNetoEtfs { get; set; }

    public DateOnly? FechaVencimientoForwards { get; set; }

    public string? ClaveForwards { get; set; }

    public string? ConsecutivoForwards { get; set; }

    public string? EntregaFuturosFx { get; set; }

    public string? MaturityPeriod { get; set; }

    public decimal? NominalFuturosFx { get; set; }

    public decimal? OtroNominalFuturosFx { get; set; }

    public decimal? FeeFuturosFx { get; set; }

    public decimal? TotalFeesFuturosFx { get; set; }

    public string? ContraparteFuturosFx { get; set; }

    public string? MedioOperacionFuturosFx { get; set; }

    public string? MonedaDelInstrumentoFuturosFx { get; set; }

    public string? Payout { get; set; }

    public decimal? StrikeOpciones { get; set; }

    public decimal? EquivQtyNomOpciones { get; set; }

    public DateTime? FechaExpiracionOpciones { get; set; }

    public DateTime? DeliveryOpciones { get; set; }

    public decimal? MoneynessOpciones { get; set; }

    public decimal? PrimaOpciones { get; set; }

    public decimal? PrimaOpciones1 { get; set; }

    public decimal? FlatPremiumOpciones { get; set; }

    public DateTime? FechaPagoPrimaOpciones { get; set; }

    public decimal? SpotOpciones { get; set; }

    public decimal? Volatility { get; set; }

    public DateTime? StartDateOpciones { get; set; }

    public string? EntregaOpciones { get; set; }

    public decimal? DiscountRateOpciones { get; set; }

    public decimal? DivYidRateOpciones { get; set; }

    public decimal? DeltaOpciones { get; set; }

    public decimal? VegaOpciones { get; set; }

    public decimal? GammaOpciones { get; set; }

    public decimal? ThetaOpciones { get; set; }

    public string? ClaveOpciones { get; set; }

    public string? ConsecutivoOpciones { get; set; }

    public string? PayoutCurrency { get; set; }

    public int? MonedaReporto { get; set; }

    public decimal? PrecioSucioReporto { get; set; }

    public decimal? ImporteReporto { get; set; }

    public decimal? InteresReporto { get; set; }

    public decimal? MontoFinalReporto { get; set; }

    public string? VencimientoPactadoReporto { get; set; }

    public decimal? Moneda1SpotYFwd { get; set; }

    public decimal? Moneda2SpotYFwd { get; set; }

    public DateOnly? FechaVencimientoSpotYFwd { get; set; }

    public string? ResultMaturitySpotYFwd { get; set; }

    public decimal? PrecioSpotYFwd { get; set; }

    public decimal? ForwardPointsSpotYFwd { get; set; }

    public string? SpotSpotYFwd { get; set; }

    public string? EntregaDiferencialesSpotYFwd { get; set; }

    public string? MonedaLiquidacionSpotYFwd { get; set; }

    public string? ClaveSpotYFwd { get; set; }

    public DateOnly? FechaRegistro { get; set; }
}
