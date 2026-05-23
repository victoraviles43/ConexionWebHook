using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtProyectosS
{
    public int IntIdProyecto { get; set; }

    public string? TxtProyecto { get; set; }

    public bool? BolActivo { get; set; }
}
