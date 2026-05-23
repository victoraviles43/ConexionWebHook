using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbHonRetLog
{
    public int LngIdHonRetLog { get; set; }

    public int LngIdHonRet { get; set; }

    public int LngIdUsuario { get; set; }

    public DateTime FecMovimiento { get; set; }

    public int? LngIdHonorarios { get; set; }

    public int? LngIdRetorno { get; set; }
}
