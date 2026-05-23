using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbHonDep
{
    public int LngIdHonDep { get; set; }

    public int? LngIdHonorarios { get; set; }

    public int? LngIdDepositos { get; set; }
}
