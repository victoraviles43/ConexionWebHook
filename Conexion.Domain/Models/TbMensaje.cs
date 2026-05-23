using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbMensaje
{
    public int IntIdChat { get; set; }

    public int? IntIdEnvio { get; set; }

    public int? IntIdRecibo { get; set; }

    public string? TxtMensaje { get; set; }

    public DateTime? FecDia { get; set; }

    public bool? BolVisto { get; set; }
}
