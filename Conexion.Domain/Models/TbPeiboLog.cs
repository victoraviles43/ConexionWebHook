using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbPeiboLog
{
    public int Id { get; set; }

    public string? TxtAccount { get; set; }

    public string? TxtCustomerKey { get; set; }

    public string? TxtStatus { get; set; }

    public string? TxtMessage { get; set; }

    public DateTime? Fecha { get; set; }
}
