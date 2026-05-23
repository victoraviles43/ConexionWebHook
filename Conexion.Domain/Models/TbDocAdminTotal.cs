using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDocAdminTotal
{
    public int LngIdDocAdminTotal { get; set; }

    public int? IntIdCliente { get; set; }

    public byte[]? ImgDoc { get; set; }

    public string? TxtExtension { get; set; }

    public int? IntIdTbDoc { get; set; }

    public int? LngIdAdministotal { get; set; }
}
