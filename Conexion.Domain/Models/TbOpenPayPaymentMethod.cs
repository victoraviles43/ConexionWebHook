using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpenPayPaymentMethod
{
    public int LngIdPaymentMethod { get; set; }

    public int LngIdCharge { get; set; }

    public string? TxtPaymentMethodType { get; set; }

    public string? TxtPaymentMethodUrl { get; set; }

    public string? TxtPaymentBank { get; set; }

    public string? TxtPaymentClabe { get; set; }

    public string? TxtPaymentAgreement { get; set; }

    public string? TxtPaymentName { get; set; }

    public string? TxtPaymentUrlSpei { get; set; }

    public virtual TbOpenPayCharge LngIdChargeNavigation { get; set; } = null!;
}
