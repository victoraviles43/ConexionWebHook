using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ViewFullpassConOpenPay
{
    public int LngIdFullpass { get; set; }

    public string NoOrden { get; set; } = null!;

    public DateOnly FechaOperacion { get; set; }

    public string Producto { get; set; } = null!;

    public int? NoDeBoletos { get; set; }

    public string? Evento { get; set; }

    public string? Zona { get; set; }

    public string? PasarelaDePago { get; set; }

    public decimal? PrecioDelBoleto { get; set; }

    public decimal? CargoPorServicioAntesDeIva { get; set; }

    public decimal? IvaCargosPorServicio { get; set; }

    public decimal? Validacion { get; set; }

    public decimal? FeeDeLaPasarela { get; set; }

    public decimal? CargoPorServicioTotal { get; set; }

    public decimal? TotalCompra { get; set; }

    public decimal? FondoDeGarantia { get; set; }

    public string? OrderStatusName { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public string? IpAddress { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? CanalImpresion { get; set; }

    public int? LngIdCharge { get; set; }

    public string? TxtCardType { get; set; }

    public string? TxtCardBrand { get; set; }

    public string? TxtCardAddress { get; set; }

    public string? TxtCardNumber { get; set; }

    public string? TxtHolderName { get; set; }

    public string? TxtBankName { get; set; }

    public string? TxtCustomerName { get; set; }

    public string? TxtCustomerLastName { get; set; }

    public string? TxtCustomerEmail { get; set; }

    public string? TxtCustomerPhoneNumber { get; set; }

    public string? TxtTransactionType { get; set; }

    public string? TxtStatus { get; set; }

    public DateTime? FecCreationDate { get; set; }

    public DateTime? FecOperationDate { get; set; }

    public string? TxtDescription { get; set; }

    public string? TxtDescriptionSinTickets { get; set; }

    public string? TxtErrorMessage { get; set; }

    public string? TxtOrderId { get; set; }

    public decimal? DblAmount { get; set; }

    public string? TxtCurrency { get; set; }

    public string? TxtMethod { get; set; }

    public decimal? DblFeeAmount { get; set; }

    public decimal? DblFeeTax { get; set; }
}
