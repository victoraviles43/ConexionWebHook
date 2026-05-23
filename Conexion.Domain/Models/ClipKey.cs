using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ClipKey
{
    public int LngId { get; set; }

    public string Token { get; set; } = null!;

    public string? TxtNombre { get; set; }
}
