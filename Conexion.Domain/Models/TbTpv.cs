using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbTpv
{
    public Guid LngIdTpvs { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtCorreo { get; set; }

    public string? TxtSerie { get; set; }

    public Guid? LngIdAdminTpv { get; set; }
}
