using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeDesarrolloTotal
{
    public int LngIdDesarrolloTotal { get; set; }

    public int? LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public string? TxtDescripcion { get; set; }

    public string? TxtNotas { get; set; }
}
