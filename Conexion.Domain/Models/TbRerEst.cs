using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbRerEst
{
    public int LngIdRetEst { get; set; }

    public int? IntIdRetorno { get; set; }

    public int? IntIdEstrategia { get; set; }
}
