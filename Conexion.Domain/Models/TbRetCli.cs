using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbRetCli
{
    public int LngIdRetCli { get; set; }

    public int? IntIdTipoRetorno { get; set; }

    public int? IntIdcliente { get; set; }

    public bool? BolActivo { get; set; }

    public int? IntIdEmpresa { get; set; }
}
