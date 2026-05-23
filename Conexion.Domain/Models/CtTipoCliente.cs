using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtTipoCliente
{
    public Guid IntIdTipoCliente { get; set; }

    public string? TxtTipoCliente { get; set; }

    public bool? BolActivo { get; set; }
}
