using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeHopedaje
{
    public int LngIdHopedaje { get; set; }

    public int? LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public decimal? NumPropiedades { get; set; }

    public decimal? DblIngresos { get; set; }

    public bool? BolPropietarioInmb { get; set; }

    public string? TxtPropietarioInmb { get; set; }

    public string? TxtNotas { get; set; }

    public int? IntIdEstadoInmueble { get; set; }
}
