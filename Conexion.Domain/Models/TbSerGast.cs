using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSerGast
{
    public int IntIdSerGast { get; set; }

    public int? IntIdTipoGasto { get; set; }

    public int? IntIdTipoServicio { get; set; }
}
