using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSerGastE
{
    public int IntIdSerGastE { get; set; }

    public int? IntIdTipoGastoE { get; set; }

    public int? IntIdTipoServicioE { get; set; }
}
