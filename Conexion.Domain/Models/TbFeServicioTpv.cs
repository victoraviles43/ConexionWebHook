using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeServicioTpv
{
    public int LngIdServicioTpv { get; set; }

    public int? LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public string? TxtDomicilio { get; set; }

    public string? TxtNumInter { get; set; }

    public string? TxtNumExt { get; set; }

    public string? TxtCodigoPostal { get; set; }

    public int? IntIdEstado { get; set; }

    public string? TxtMunicipio { get; set; }

    public decimal? NumTpv { get; set; }

    public string? TxtGiroNegocio { get; set; }

    public decimal? NumTransDia { get; set; }

    public bool? BolTicketImpreso { get; set; }

    public string? TxtNotas { get; set; }
}
