using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtSucursal
{
    public Guid IntIdSucursal { get; set; }

    public Guid? IntIdOficina { get; set; }

    public string? TxtSucursal { get; set; }
}
