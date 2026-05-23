using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSerGastZ
{
    public int IntIdSerGastZ { get; set; }

    public int? IntIdTipoGastoZ { get; set; }

    public int? IntIdTipoServicioZ { get; set; }
}
