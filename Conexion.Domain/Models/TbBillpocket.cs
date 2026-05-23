using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbBillpocket
{
    public int LngId { get; set; }

    public int? TxtTransactionId { get; set; }

    public string? TxtAuthorizationNumber { get; set; }

    public string? TxtBank { get; set; }

    public string? TxtCardBrand { get; set; }

    public string? TxtCardType { get; set; }

    public string? TxtCaptureMethod { get; set; }

    public decimal? DblCommission { get; set; }

    public bool? BolCountercharged { get; set; }

    public DateTime? FechDate { get; set; }

    public string? TxtDetails { get; set; }

    public string? TxtDevice { get; set; }

    public string? TxtErrorDetail { get; set; }

    public string? TxtMaskedCard { get; set; }

    public string? TxtMsi { get; set; }

    public decimal? DblRetention { get; set; }

    public string? TxtRejectionCode { get; set; }

    public decimal? DblSubtotal { get; set; }

    public decimal? DblSurcharge { get; set; }

    public decimal? DblTip { get; set; }

    public decimal? DblTotalAmount { get; set; }

    public string? TxtTransactionType { get; set; }

    public string? TxtTransactionStatus { get; set; }

    public decimal? DblVat { get; set; }

    public string? TxtCliente { get; set; }

    public string? TxtCorreo { get; set; }
}
