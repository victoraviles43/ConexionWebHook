using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtEmpresa
{
    public int IntIdEmpresa { get; set; }

    public string? TxtEmpresa { get; set; }

    public int? IntSegemento { get; set; }

    public string? TxtNom { get; set; }
}
