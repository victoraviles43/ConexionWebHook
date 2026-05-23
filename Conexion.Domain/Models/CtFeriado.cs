using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtFeriado
{
    public int IntIdFeriado { get; set; }

    public DateOnly? FecFeriado { get; set; }
}
