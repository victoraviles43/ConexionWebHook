using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeServiciosFinanciero
{
    public int LngIdServFinanciero { get; set; }

    public int? LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public bool? BolEfectivoAhorros { get; set; }

    public bool? BolEfectivoRecc { get; set; }
}
