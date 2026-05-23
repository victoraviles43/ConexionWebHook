using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtSubOperacion
{
    public int IntIdSuboperacion { get; set; }

    public string? TxtSuboperacion { get; set; }

    public int? IntIdOperacion { get; set; }
}
