using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpenPayCharge
{
    public int LngIdCharge { get; set; }

    public string TxtId { get; set; } = null!;

    public string? TxtAuthorization { get; set; }

    public string? TxtOperationType { get; set; }

    public string? TxtTransactionType { get; set; }

    public string? TxtStatus { get; set; }

    public bool? BolConciliated { get; set; }

    public DateTime? FecCreationDate { get; set; }

    public DateTime? FecOperationDate { get; set; }

    public string? TxtDescription { get; set; }

    public string? TxtErrorMessage { get; set; }

    public string? TxtOrderId { get; set; }

    public decimal? DblAmount { get; set; }

    public string? TxtCurrency { get; set; }

    public string? TxtMethod { get; set; }

    public virtual ICollection<TbOpenPayCard> TbOpenPayCards { get; set; } = new List<TbOpenPayCard>();

    public virtual ICollection<TbOpenPayCustomer> TbOpenPayCustomers { get; set; } = new List<TbOpenPayCustomer>();

    public virtual ICollection<TbOpenPayFee> TbOpenPayFees { get; set; } = new List<TbOpenPayFee>();

    public virtual ICollection<TbOpenPayPaymentMethod> TbOpenPayPaymentMethods { get; set; } = new List<TbOpenPayPaymentMethod>();
}
