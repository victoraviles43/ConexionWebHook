using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtUbicacion
{
    public int IntIdUbicacion { get; set; }

    public string? TxtCiudad { get; set; }

    public string? TxtNomCorto { get; set; }
}
