using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtDepartamento
{
    public int IntIdDepartamentos { get; set; }

    public string? TxtDepartamento { get; set; }

    public string? TxtNomCorto { get; set; }

    public bool? BolActivo { get; set; }
}
