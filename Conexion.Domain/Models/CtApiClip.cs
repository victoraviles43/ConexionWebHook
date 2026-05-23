using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtApiClip
{
    public int LngId { get; set; }

    public string TxtNumeroIdentificacion { get; set; } = null!;

    public decimal DblIdOperacion { get; set; }

    public string DblCodigo { get; set; } = null!;

    public string TxtTipoMedioPago { get; set; } = null!;

    public string TxtMedioPago { get; set; } = null!;

    public string? TxtPaisOrigen { get; set; }

    public string? TxtTipoOperacion { get; set; }

    public decimal? DblValorCompra { get; set; }

    public string? TxtMoneda { get; set; }

    public decimal? DblMontoRecibidoSplit { get; set; }

    public DateTime? FecOrigen { get; set; }

    public decimal? DblComision { get; set; }

    public decimal? DblMontoOperacionDinero { get; set; }

    public string? TxtMonedaLiquidacion { get; set; }

    public DateTime? FecAprobacion { get; set; }

    public decimal? DblMontoOperacion { get; set; }

    public decimal? DblCuponDescuento { get; set; }

    public string? TxtDatosExtra { get; set; }

    public decimal? DblComisionIva { get; set; }

    public decimal? DblComisionCuotas { get; set; }

    public decimal? DblCostoEnvio { get; set; }

    public decimal? DblImpuestosRetenciones { get; set; }

    public int? IntCuotas { get; set; }

    public string? TxtDetalleImpuestos { get; set; }

    public decimal? DblIdCaja { get; set; }

    public decimal? DblIdSucursal { get; set; }

    public string? TxtNombreSucursal { get; set; }

    public decimal? DblIdCajaUsuario { get; set; }

    public string? TxtNombreCaja { get; set; }

    public decimal? DblIdSucursalUsuario { get; set; }

    public decimal? DblIdOrden { get; set; }

    public decimal? DblIdEnvio { get; set; }

    public string? TxtModoEnvio { get; set; }

    public decimal? DblIdPaquete { get; set; }

    public string? TxtImpuestosDesagregados { get; set; }

    public string? TxtNumeroSerie { get; set; }

    public decimal? DblBilleteraVirtual { get; set; }

    public string? TxtBancoOrigen { get; set; }

    public decimal? DblNumeroInicialTarjeta { get; set; }

    public string? TxtOperationTags { get; set; }

    public string? TxtCanalVenta { get; set; }

    public string? TxtPlataformaCobro { get; set; }

    public DateTime? FecLiberacion { get; set; }

    public string? TxtCodigoProductoSku { get; set; }

    public string? TxtDetalleVenta { get; set; }

    public int? IntIdIntentoOperacion { get; set; }
}
