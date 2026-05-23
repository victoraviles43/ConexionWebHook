using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeBoletera
{
    public int LngIdBoletDigi { get; set; }

    public int? LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public string? TxtNombreEvento { get; set; }

    public string? TxtDomicilio { get; set; }

    public string? TxtNumInter { get; set; }

    public string? TxtNumExt { get; set; }

    public string? TxtCodigoPostal { get; set; }

    public int? IntIdEstado { get; set; }

    public string? TxtMunicipio { get; set; }

    public decimal? NumAsistentes { get; set; }

    public decimal? DblPrecioPromedio { get; set; }

    public DateOnly? FecInicioPre { get; set; }

    public DateOnly? FecInicioEve { get; set; }

    public DateOnly? FecTerminoEve { get; set; }

    public bool? BolLinkPago { get; set; }

    public string? TxtNotas { get; set; }
}
