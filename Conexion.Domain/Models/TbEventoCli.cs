using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEventoCli
{
    public int LngIdEventoCli { get; set; }

    public int? IntIdEvento { get; set; }

    public int? IntIdCliente { get; set; }

    public bool? BolActivo { get; set; }
}
