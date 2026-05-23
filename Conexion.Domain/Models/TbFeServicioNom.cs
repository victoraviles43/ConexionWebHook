using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeServicioNom
{
    public int LngIdServicioNom { get; set; }

    public int? LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public int? IntIdPedicidad { get; set; }

    public int? IntIdClaseRiesgo { get; set; }

    public decimal? DblPrimaRiesgo { get; set; }

    public int? IntIdEsquema { get; set; }

    public decimal? NumEmpleados { get; set; }

    public string? TxtNotas { get; set; }
}
