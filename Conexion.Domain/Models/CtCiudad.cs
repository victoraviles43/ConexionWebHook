using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtCiudad
{
    public Guid IntIdCiudad { get; set; }

    public string? TxtCiudad { get; set; }

    public Guid? IntIdEstado { get; set; }
}
