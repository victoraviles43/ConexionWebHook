using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbHonRet
{
    public int LngIdHonRet { get; set; }

    public int? LngIdHonorarios { get; set; }

    public int? LngIdRetorno { get; set; }
}
