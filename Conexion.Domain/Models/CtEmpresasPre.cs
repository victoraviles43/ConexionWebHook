using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtEmpresasPre
{
    public int IntIdEmpresa { get; set; }

    public string? TxtEmpresa { get; set; }

    public int? IntSegmento { get; set; }

    public string? TxtNom { get; set; }
}
