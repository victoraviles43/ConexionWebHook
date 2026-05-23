using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtFeconsecutivo
{
    public int IntIdConsecutivo { get; set; }

    public string? TxtConsecutivo { get; set; }

    public int? NumValor { get; set; }
}
