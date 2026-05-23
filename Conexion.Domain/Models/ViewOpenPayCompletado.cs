using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ViewOpenPayCompletado
{
    public int LngIdCharge { get; set; }

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
