using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtTipoServicioE
{
    public int IntIdTipoServicioE { get; set; }

    public string? TxtTipoServicioE { get; set; }

    public string? TxtNomCorto { get; set; }

    public bool? BolActivo { get; set; }
}
