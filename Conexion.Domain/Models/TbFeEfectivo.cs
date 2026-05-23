using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeEfectivo
{
    public int LngIdEfectivo { get; set; }

    public int? LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public bool? BolAhoros { get; set; }

    public bool? BolRecurrente { get; set; }

    public bool? BolAsimilado { get; set; }

    public bool? BolSindicato { get; set; }

    public bool? BolTransferencia { get; set; }

    public bool? BolEfectivo { get; set; }

    public bool? BolCripto { get; set; }

    public bool? BolMonedero { get; set; }

    public string? TxtNotas { get; set; }
}
