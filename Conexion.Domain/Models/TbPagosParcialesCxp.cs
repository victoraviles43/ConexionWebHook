using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbPagosParcialesCxp
{
    public int LngPagoParcialCxp { get; set; }

    public int? IntIdSolicitdCxp { get; set; }

    public decimal? DblMonto { get; set; }

    public DateOnly? FecPago { get; set; }
}
