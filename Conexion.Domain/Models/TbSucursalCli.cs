using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSucursalCli
{
    public int LngIdSucCli { get; set; }

    public int? IntIdSucursal { get; set; }

    public int? IntIdCliente { get; set; }

    public bool? BolActivo { get; set; }
}
