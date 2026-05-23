using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbBrEntrada
{
    public Guid LngIdEntradas { get; set; }

    public string? TxtRegistro { get; set; }

    public int IntIdInt { get; set; }

    public DateOnly? FecInicio { get; set; }

    public decimal? DblValorReis { get; set; }

    public decimal? DblPor { get; set; }

    public decimal? DblTc { get; set; }

    public decimal? DblValorTotal { get; set; }

    public Guid? IntIdStatus { get; set; }
}
