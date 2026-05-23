using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProductoCli
{
    public int LngIdProductoCli { get; set; }

    public int? IntIdProducto { get; set; }

    public int? IntIdCliente { get; set; }

    public bool? BolActivo { get; set; }
}
