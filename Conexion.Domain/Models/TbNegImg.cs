using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbNegImg
{
    public int IntIdNegImg { get; set; }

    public int? IntIdUnidadNegocio { get; set; }

    public string? TxtUrlImg { get; set; }

    public bool? BolPrincipal { get; set; }
}
