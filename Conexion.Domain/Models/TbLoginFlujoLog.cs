using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbLoginFlujoLog
{
    public int LngIdLoginFlujosLog { get; set; }

    public int LngIdLoginFlujos { get; set; }

    public int LngIdUsuario { get; set; }

    public DateTime FecMovimiento { get; set; }

    public string? TxtNombre { get; set; }

    public DateTime? FecIncio { get; set; }

    public int? LngIdFlujo { get; set; }

    public int? IntIdStatus { get; set; }
}
