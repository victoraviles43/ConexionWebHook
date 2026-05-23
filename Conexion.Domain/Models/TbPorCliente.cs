using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbPorCliente
{
    public int LngIdPorcliente { get; set; }

    public int? IntIdCliente { get; set; }

    public decimal? DblPorFactura { get; set; }
}
