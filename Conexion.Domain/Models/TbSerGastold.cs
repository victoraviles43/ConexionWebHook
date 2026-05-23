using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSerGastold
{
    public int IntIdSerGast { get; set; }

    public int? IntIdTipoGasto { get; set; }

    public string? IntIdTipoServicio { get; set; }
}
