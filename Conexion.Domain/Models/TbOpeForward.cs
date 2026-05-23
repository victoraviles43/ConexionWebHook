using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpeForward
{
    public Guid LngForwards { get; set; }

    public Guid? LngIdGeneral { get; set; }

    public DateOnly? FecVence { get; set; }

    public string? TxtStrategy { get; set; }

    public string? TxtClave { get; set; }

    public string? TxtConsecutivo { get; set; }

    public DateTime? FecIni { get; set; }

    public bool? BolCongelar { get; set; }

    public int? IntIdEntrega { get; set; }
}
