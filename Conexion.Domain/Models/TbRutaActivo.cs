using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbRutaActivo
{
    public int IntIdRutaActivo { get; set; }

    public int? LngIdActivo { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtRutaActivo { get; set; }

    public DateTime? FecRutaActivo { get; set; }

    public string? TxtExtension { get; set; }
}
