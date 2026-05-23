using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpenPayFee
{
    public int LngIdFee { get; set; }

    public int LngIdCharge { get; set; }

    public decimal? DblFeeAmount { get; set; }

    public decimal? DblFeeTax { get; set; }

    public decimal? DblFeeSurcharge { get; set; }

    public decimal? DblFeeBaseCommission { get; set; }

    public string? TxtFeeCurrency { get; set; }

    public virtual TbOpenPayCharge LngIdChargeNavigation { get; set; } = null!;
}
