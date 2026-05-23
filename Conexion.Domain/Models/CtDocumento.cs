using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtDocumento
{
    public Guid LngIdDocumento { get; set; }

    public string? TxtDocumento { get; set; }

    public int? IntTipo { get; set; }
}
