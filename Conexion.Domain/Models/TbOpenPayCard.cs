using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpenPayCard
{
    public int LngIdCard { get; set; }

    public int LngIdCharge { get; set; }

    public string? TxtCardType { get; set; }

    public string? TxtCardBrand { get; set; }

    public string? TxtCardAddress { get; set; }

    public string? TxtCardNumber { get; set; }

    public string? TxtHolderName { get; set; }

    public string? TxtExpirationYear { get; set; }

    public string? TxtExpirationMonth { get; set; }

    public bool? BolAllowsCharges { get; set; }

    public bool? BolAllowsPayouts { get; set; }

    public string? TxtBankName { get; set; }

    public string? TxtCardBusinessType { get; set; }

    public string? TxtDcc { get; set; }

    public string? TxtBankCode { get; set; }

    public virtual TbOpenPayCharge LngIdChargeNavigation { get; set; } = null!;
}
