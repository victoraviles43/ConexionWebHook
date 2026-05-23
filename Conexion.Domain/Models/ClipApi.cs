using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ClipApi
{
    public int LngId { get; set; }

    public string? TxtReceiptNo { get; set; }

    public DateTime? FecCreatedAt { get; set; }

    public string? TxtUserEmail { get; set; }

    public string? TxtStatus { get; set; }

    public string? TxtPaymentMethod { get; set; }

    public string? TxtSubType { get; set; }

    public string? TxtCurrency { get; set; }

    public string? TxtTerms { get; set; }

    public decimal? DblAmount { get; set; }

    public decimal? DblTip { get; set; }

    public decimal? DblTotal { get; set; }

    public string? TxtMerchantInvoice { get; set; }

    public string? TxtLocationLongitude { get; set; }

    public string? TxtLocationLatitude { get; set; }

    public string? TxtCardBrand { get; set; }

    public string? TxtCardIssuer { get; set; }

    public string? TxtCardLast4 { get; set; }

    public string? TxtCliente { get; set; }
}
