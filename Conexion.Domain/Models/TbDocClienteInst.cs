using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDocClienteInst
{
    public Guid LngIdDocClienteInst { get; set; }

    public Guid? LngIdCliente { get; set; }

    public byte[]? ImgDoc { get; set; }

    public string? TxtExtension { get; set; }
}
