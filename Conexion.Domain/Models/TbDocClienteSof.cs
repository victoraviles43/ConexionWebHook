using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDocClienteSof
{
    public Guid LngIdDocClienteSof { get; set; }

    public Guid? LngIdCliente { get; set; }

    public byte[]? ImgDoc { get; set; }

    public string? TxtExtension { get; set; }
}
