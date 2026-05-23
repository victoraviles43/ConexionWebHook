using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtProTalent
{
    public int IntIdProyecto { get; set; }

    public string? TxtProyecto { get; set; }

    public bool? BolActivo { get; set; }
}
