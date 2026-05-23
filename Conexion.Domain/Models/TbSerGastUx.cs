using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSerGastUx
{
    public int IntIdSerGastUx { get; set; }

    public int? IntIdTipoGastoUx { get; set; }

    public int? IntIdTipoServicioUx { get; set; }
}
