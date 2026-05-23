using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbLoginFlujo
{
    public int LngIdLoginFlujos { get; set; }

    public string? TxtNombre { get; set; }

    public DateTime? FecIncio { get; set; }

    public int? LngIdFlujo { get; set; }

    public int? IntIdStatus { get; set; }
}
