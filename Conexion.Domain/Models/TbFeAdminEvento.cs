using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeAdminEvento
{
    public int LngIdAdminEventos { get; set; }

    public int? LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public string? TxtNombreEvento { get; set; }

    public string? TxtLugarEvento { get; set; }

    public int? IntIdEstado { get; set; }

    public int? NumAsistentes { get; set; }

    public decimal? DblPrecioPromedio { get; set; }

    public DateOnly? FecInicioPre { get; set; }

    public DateOnly? FecInicioEve { get; set; }

    public DateOnly? FecTerminoEve { get; set; }

    public bool? BolTpv { get; set; }

    public bool? BolAdminTesoreria { get; set; }

    public bool? BolCustodiaValores { get; set; }

    public bool? BolBrazaletes { get; set; }

    public bool? BolAudiInventarios { get; set; }

    public int? NumTpvtaquillas { get; set; }

    public int? NumTpvcentrConsumo { get; set; }

    public int? NumTpvmercancias { get; set; }

    public int? NumTpvbarras { get; set; }

    public int? NumTpvVip { get; set; }

    public bool? BolLinkPago { get; set; }

    public string? TxtNotas { get; set; }
}
