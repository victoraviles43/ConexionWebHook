using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbScore
{
    public Guid IntIdScore { get; set; }

    public Guid? LngIdCliente { get; set; }

    public DateOnly? FecDia { get; set; }

    public int? IntValorScore { get; set; }

    public Guid? IntIdUsuario { get; set; }
}
