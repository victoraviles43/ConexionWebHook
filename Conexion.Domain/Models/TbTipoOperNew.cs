using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbTipoOperNew
{
    public int LngIdTipoOper { get; set; }

    public int? LngIdflujo { get; set; }

    public int? IntIdTipoOper { get; set; }

    public int? IntIdcliente { get; set; }

    public decimal? DblComision { get; set; }

    public bool? BolActivo { get; set; }

    public bool? BolRemantenteIva { get; set; }

    public bool? BolPorComercial { get; set; }
}
