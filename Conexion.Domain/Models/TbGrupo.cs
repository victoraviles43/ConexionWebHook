using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbGrupo
{
    public int IntIdGrupo { get; set; }

    public int? IntIdPlaza { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtGiro { get; set; }
}
