using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class Payment
{
    public int Id { get; set; }

    public string TxtReceiptNo { get; set; } = null!;

    public DateOnly? FecPaymentDate { get; set; }

    public decimal? DblAmount { get; set; }

    public decimal? DblFee { get; set; }

    public decimal? DblTax { get; set; }

    public decimal? DblTotalRetention { get; set; }

    public decimal? DblSettledAmount { get; set; }

    public string? TxtPaymentMethod { get; set; }

    public string? TxtCardBrand { get; set; }

    public string? TxtLast4 { get; set; }

    public string? TxtIssuer { get; set; }

    public string? TxtUserEmail { get; set; }
}
