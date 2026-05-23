using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeFullPassPrime
{
    public int LngIdFullPassPrime { get; set; }

    public int? LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public string? TxtDescripcion { get; set; }

    public string? TxtNotas { get; set; }
}
