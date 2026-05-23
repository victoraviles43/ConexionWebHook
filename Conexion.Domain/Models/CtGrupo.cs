using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtGrupo
{
    public int IntIdGrupo { get; set; }

    public string? TxtGrupo { get; set; }

    public int? IntIdCorporativo { get; set; }
}
