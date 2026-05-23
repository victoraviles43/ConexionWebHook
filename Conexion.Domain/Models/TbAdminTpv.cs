using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbAdminTpv
{
    public Guid LngIdAdminTpv { get; set; }

    public string? TxtRegAdminTpv { get; set; }

    public DateTime? FecIncio { get; set; }

    public DateTime? FecFin { get; set; }

    public int? IntIdCliente { get; set; }

    public Guid? IntIdEmpresaTpv { get; set; }

    public Guid? IntIdStatusAdmin { get; set; }

    public string? TextNombre { get; set; }
}
