using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class BillpocketKey
{
    public int LngId { get; set; }

    public string Token { get; set; } = null!;

    public string? TxtNombre { get; set; }

    public string? Tokenupdate { get; set; }

    public string? TxtCorreo { get; set; }
}
