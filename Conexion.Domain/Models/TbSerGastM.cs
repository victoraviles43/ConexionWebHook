using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSerGastM
{
    public int IntIdSerGastM { get; set; }

    public int? IntIdTipoGastoM { get; set; }

    public int? IntIdTipoServicioM { get; set; }
}
