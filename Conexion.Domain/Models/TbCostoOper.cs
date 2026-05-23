using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCostoOper
{
    public int IntIdCostoOper { get; set; }

    public string? TxtCostoOper { get; set; }

    public decimal? DblCostoOper { get; set; }
}
