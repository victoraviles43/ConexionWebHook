using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtTipoGastoE
{
    public int IntIdTipoGastoE { get; set; }

    public string? TxtTipoGastoE { get; set; }

    public string? TxtNomCorto { get; set; }

    public bool? BolActivo { get; set; }
}
