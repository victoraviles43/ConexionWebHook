using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbBanco
{
    public int LngId { get; set; }

    public DateOnly? Col01 { get; set; }

    public string? Col02 { get; set; }

    public string? Col03 { get; set; }

    public DateOnly? FecDia { get; set; }
}
