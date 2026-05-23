using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbMotivosF
{
    public int IntIdMotivo { get; set; }

    public int? IntIdSolicitdCxR { get; set; }

    public decimal? DblValor { get; set; }

    public string? TxtMotivo { get; set; }

    public DateOnly? FecRegistro { get; set; }
}
