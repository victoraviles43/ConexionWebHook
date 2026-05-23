using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbTransactionsPeibo
{
    public int LngIdTransactionsPeibo { get; set; }

    public int? TxtTransactionId { get; set; }

    public string? TxtTrackingCode { get; set; }

    public DateTime FecDateTime { get; set; }

    public string? TxtConcept { get; set; }

    public string? TxtReference { get; set; }

    public string? DblAmount { get; set; }

    public string? TxtBeneficiaryAccount { get; set; }

    public string? TxtOriginatorAccount { get; set; }

    public string? TxtOriginatorBank { get; set; }

    public string? TxtOriginatorName { get; set; }

    public string? TxtBeneficiaryName { get; set; }

    public string? TxtOriginatorTaxId { get; set; }

    public string? TxtBeneficiaryTaxId { get; set; }

    public string? TxtStatus { get; set; }

    public string? TxtType { get; set; }
}
