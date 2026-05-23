using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProducto
{
    public Guid IntIdProductos { get; set; }

    public string? TxtProductos { get; set; }

    public Guid? LngIdCliente { get; set; }

    public Guid? IntIdProducto { get; set; }
}
