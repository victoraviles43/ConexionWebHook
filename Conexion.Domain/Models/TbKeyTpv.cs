using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbKeyTpv
{
    public Guid LngIdKey { get; set; }

    public string? TxtUsername { get; set; }

    public string? TxtPassword { get; set; }

    public Guid? IntIdEmpresaTpv { get; set; }
}
