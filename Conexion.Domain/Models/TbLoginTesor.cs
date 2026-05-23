using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbLoginTesor
{
    public int LngIdLoginTesor { get; set; }

    public string? TxtNombre { get; set; }

    public DateTime? FecIncio { get; set; }

    public int? LngIdFlujo { get; set; }

    public int? IntIdStatus { get; set; }
}
