using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtPayoutCurrency
{
    public Guid IntIdPayoutCurrency { get; set; }

    public string? TxtPayoutCurrency { get; set; }
}
